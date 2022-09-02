Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("Quantos pomodoros você deseja fazer?");
    int PomodoresCycles = int.Parse(Console.ReadLine());

    PreStart();
    Start(PomodoresCycles);
    End(PomodoresCycles);
}

static void PreStart()
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Go!");
    Thread.Sleep(1000);
}

static void End(int cycles)
{
    Console.WriteLine($"Você realizou {cycles} de pomodoros, estudando {cycles * 25} minutos, ou ainda {cycles * 25 * 60} segundos");
    Thread.Sleep(1000);
    Console.WriteLine("Obrigado por usar nosso App!");
    Thread.Sleep(1500);
}

static void Start(int cycles)
{
    
    while (cycles > 0)
    {
        Start25Minutes();
        Start5Minutes();
        cycles--;
        Console.WriteLine($"Ciclos restantes: {cycles}");
        Thread.Sleep(1000);

    }
}


static void Start25Minutes()
{
    Console.WriteLine("Iniciando o pomodoro");
    int goalTime = 5;
    int currentTime = 0;
    
    while (currentTime < goalTime)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
}

static void Start15Minutes()
{
    Console.WriteLine("Tire uma pausa longa!");
    Thread.Sleep(1000);
    int goalTime = 5;
    int currentTime = 0;

    while (currentTime < goalTime)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(2000);
    }

    Console.WriteLine("Descansou o suficiente? Back to work!");


}

static void Start5Minutes()
{
    Console.WriteLine("Hora de descansar!");
    Thread.Sleep(1000);
    //int goalTime = 25 * 60;
    int goalTime = 5;
    int currentTime = 0;

    while (currentTime < goalTime)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Beep();
    Console.WriteLine("De volta ao trabalho!");
    Thread.Sleep(1000);

}




