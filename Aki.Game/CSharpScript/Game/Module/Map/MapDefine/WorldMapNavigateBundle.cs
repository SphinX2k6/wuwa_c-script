using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200453F RID: 17727
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateBundle
	{
		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x0602CAF9 RID: 183033 RVA: 0x00C86A4A File Offset: 0x00C84C4A
		// (set) Token: 0x0602CAFA RID: 183034 RVA: 0x00C86A52 File Offset: 0x00C84C52
		public List<IWorldMapNavigateCountryData> CountryList { get; set; } = new List<IWorldMapNavigateCountryData>();

		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x0602CAFB RID: 183035 RVA: 0x00C86A5B File Offset: 0x00C84C5B
		// (set) Token: 0x0602CAFC RID: 183036 RVA: 0x00C86A63 File Offset: 0x00C84C63
		public Dictionary<int, IWorldMapNavigateCountry> CountryMap { get; set; } = new Dictionary<int, IWorldMapNavigateCountry>();

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x0602CAFD RID: 183037 RVA: 0x00C86A6C File Offset: 0x00C84C6C
		// (set) Token: 0x0602CAFE RID: 183038 RVA: 0x00C86A74 File Offset: 0x00C84C74
		public Dictionary<int, IWorldMapNavigate> AreaMap { get; set; } = new Dictionary<int, IWorldMapNavigate>();
	}
}
