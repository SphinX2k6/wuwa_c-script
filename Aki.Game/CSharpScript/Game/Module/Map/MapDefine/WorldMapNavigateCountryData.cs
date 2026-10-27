using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005570 RID: 21872
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateCountryData : IWorldMapNavigateCountryData
	{
		// Token: 0x1700861D RID: 34333
		// (get) Token: 0x06037C32 RID: 228402 RVA: 0x00D39007 File Offset: 0x00D37207
		// (set) Token: 0x06037C33 RID: 228403 RVA: 0x00D3900F File Offset: 0x00D3720F
		public int CountryId { get; set; }

		// Token: 0x1700861E RID: 34334
		// (get) Token: 0x06037C34 RID: 228404 RVA: 0x00D39018 File Offset: 0x00D37218
		// (set) Token: 0x06037C35 RID: 228405 RVA: 0x00D39020 File Offset: 0x00D37220
		public IWorldMapNavigateCountry NavigateCountry { get; set; }
	}
}
