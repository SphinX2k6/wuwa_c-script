using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000244 RID: 580
	[NullableContext(1)]
	[Nullable(0)]
	public class SplashRegionGeoIpProvider
	{
		// Token: 0x06000EA2 RID: 3746 RVA: 0x00056683 File Offset: 0x00054883
		public SplashRegionGeoIpProvider(string name, string url, Regex countryRegex)
		{
			this.Name = name;
			this.Url = url;
			this.CountryRegex = countryRegex;
		}

		// Token: 0x04000971 RID: 2417
		public readonly string Name;

		// Token: 0x04000972 RID: 2418
		public readonly string Url;

		// Token: 0x04000973 RID: 2419
		public readonly Regex CountryRegex;
	}
}
