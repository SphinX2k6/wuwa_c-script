using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004542 RID: 17730
	[NullableContext(1)]
	public interface IWorldMapNavigateCountryData
	{
		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x0602CB09 RID: 183049
		int CountryId { get; }

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x0602CB0A RID: 183050
		// (set) Token: 0x0602CB0B RID: 183051
		IWorldMapNavigateCountry NavigateCountry { get; set; }
	}
}
