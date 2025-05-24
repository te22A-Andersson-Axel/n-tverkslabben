HttpClient client = new();

client.BaseAddress = new("https://pokeapi.co/api/v2/");

HttpResponseMessage response = client.GetAsync("pokemon/snorlax").Result;

string snorlax = response.Content.ReadAsStringAsync().Result;

File.WriteAllText("snorlax.json", snorlax);

Console.ReadLine();