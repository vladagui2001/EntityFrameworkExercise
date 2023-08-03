using Sample.Data;
using Sample.Data.Entities;

//Utiliza el LibraryContext con la base de datos contenida
using var db = new LibraryContext();

var movietodelete = db.Movies.Where(x => x.Director == "Andrew Adamson");
foreach (var deletemovie in movietodelete)
    db.Movies.Remove(deletemovie);

Movie movie = new Movie()
{
    Director = "Jon Favreau",
    Name = "Iron Man",
    Description = "When Tony Stark, an industrialist, is captured, he constructs a high-tech armoured suit to escape. Once he manages to escape, he decides to use his suit to fight against evil forces to save the world.",
    Rating = "4*",
    ReleaseDate = DateTime.Now,

};

Movie movie2 = new Movie()
{
    Director = "Guillermo del Toro",
    Name = "Pinocchio (2022)",
    Description = "A father's wish magically brings a wooden boy to life in Italy, giving him a chance to care for the child.",
    Rating = "4.5*",
    ReleaseDate = DateTime.Now,

};

Movie movie3 = new Movie()
{
    Director = "Andrew Adamson",
    Name = "Shrek",
    Description = "Shrek, an ogre, embarks on a journey with a donkey to rescue Princess Fiona from a vile lord and regain his swamp.",
    Rating = "4.7*",
    ReleaseDate = DateTime.Now,

};

//Añade los datos a la DB
db.Movies.Add(movie);
db.Movies.Add(movie2);
db.Movies.Add(movie3);
db.SaveChanges();

//Select en Movies dónde Director == Andrew Adamson
var moviewhere = db.Movies.Where(x => x.Director == "Andrew Adamson");

//Imprime los insert
foreach (var item in db.Movies)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.Rating);
    Console.WriteLine(item.ReleaseDate);
    Console.WriteLine(item.Director);
}