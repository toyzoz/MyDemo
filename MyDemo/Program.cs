var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.WebHost.UseUrls("http://*:50002");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
// 111
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
