internal class Program
{
    private static void Main(string[] args)
    {
        byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
        int b = 10; //Convert this value into "short" type (assign into another short type of variable)
        string c = "10,34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
        decimal d = 20.3m; //Convert this value into "string" type (assign into another string type of variable)

        short aa = a;
        short bb = (short)b;
        double cc = double.Parse(c);
        bool isSuccessful = decimal.TryParse(c, out decimal ccc);
        string dd = Convert.ToString(d);

        Console.WriteLine($"byte -> short (implicit): {aa}\nint -> short (explicit): {bb}\nstring -> double (Parse): {cc}" +
                          $"\nstring -> decimal (TryParse): {ccc}\ndecimal -> string (Convert class): {dd}");

    }
}