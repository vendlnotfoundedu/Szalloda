using Szalloda;

if (File.Exists("szobak.txt"))
{
    foreach (string sor in File.ReadAllLines("szobak.txt"))
    {
        sor.Split(";");
        int.TryParse(sor[1]);
    }
}
else Console.WriteLine("A szobak.txt fájl nem található.");