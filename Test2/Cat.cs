public class Cat
{
    public string Name { get; }
    public int Age { get; }

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} каже: Мяу!");
    }
}
