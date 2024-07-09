namespace MethodsDemoCSharp_49;

class Program
{
    //Method definition (creating a method)
    //Disregard the keyword "static" until we get to that lesson
    //Pascal casing - EveryWordStartsWithCapital
    //Parts of a method
    //Access modifier - return type - method name - parameter list - scope/body (what the method does when used)
    public static void GreetPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static int AddTwoNums(int numOne, int numTwo)
    {
        // int sum = numOne + numTwo;
        // return sum;

        return numOne + numTwo;
    }

    public static void GetUserNameAndGreet()
    {
        Console.WriteLine("Please give me your name:");

        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}!");
    }
    
    static void Main(string[] args)
    {
        //Calling a method (using a method)
        GreetPerson("Seth");

        // int sum = AddTwoNums(2, 2);
        // Console.WriteLine(sum);

        Console.WriteLine(AddTwoNums(2, 3));
        
        GetUserNameAndGreet();

    }
}
