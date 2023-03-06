using System;

//define a struct with two fields
struct Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {
        //declare var 
        Person p;

        
        Console.WriteLine("Please enter your name:");
        p.Name = Console.ReadLine();

        
        Console.WriteLine("Please enter your age:");
        p.Age = int.Parse(Console.ReadLine());

        //print out name and age 
        Console.WriteLine($"Hello {p.Name}, you are {p.Age} years old!");
    }
}
