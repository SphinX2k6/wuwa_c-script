using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000249 RID: 585
	[NullableContext(1)]
	[Nullable(0)]
	public class SplashRegionGeoIpProvider
	{
		// Token: 0x06000EE3 RID: 3811 RVA: 0x000591C7 File Offset: 0x000573C7
		public SplashRegionGeoIpProvider(string name, string url, Regex countryRegex)
		{
			this.Name = name;
			this.Url = url;
			this.CountryRegex = countryRegex;
		}

		// Token: 0x040009B9 RID: 2489
		public readonly string Name;

		// Token: 0x040009BA RID: 2490
		public readonly string Url;

		// Token: 0x040009BB RID: 2491
		public readonly Regex CountryRegex;
	}
}
