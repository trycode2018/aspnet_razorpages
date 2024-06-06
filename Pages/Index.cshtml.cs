using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myRazorApp.wwwroot.Pages;

public class Index : PageModel
{
    public List<Category> categories { get; set; }= new();
    public async Task OnGet()
    {
        //await Task.Delay(5000);
        for (int i = 0; i < 100; i++)
        {
            categories.Add(
                new Category(i,$"Category {i}",i*18.95M));
        }
    }
}
public record Category(
     int Id,string Title, decimal Price
    );
    
    