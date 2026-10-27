using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200556C RID: 21868
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateBundle
	{
		// Token: 0x17008614 RID: 34324
		// (get) Token: 0x06037C1F RID: 228383 RVA: 0x00D38F76 File Offset: 0x00D37176
		// (set) Token: 0x06037C20 RID: 228384 RVA: 0x00D38F7E File Offset: 0x00D3717E
		public List<IWorldMapNavigateCountryData> CountryList { get; set; } = new List<IWorldMapNavigateCountryData>();

		// Token: 0x17008615 RID: 34325
		// (get) Token: 0x06037C21 RID: 228385 RVA: 0x00D38F87 File Offset: 0x00D37187
		// (set) Token: 0x06037C22 RID: 228386 RVA: 0x00D38F8F File Offset: 0x00D3718F
		public Dictionary<int, IWorldMapNavigateCountry> CountryMap { get; set; } = new Dictionary<int, IWorldMapNavigateCountry>();

		// Token: 0x17008616 RID: 34326
		// (get) Token: 0x06037C23 RID: 228387 RVA: 0x00D38F98 File Offset: 0x00D37198
		// (set) Token: 0x06037C24 RID: 228388 RVA: 0x00D38FA0 File Offset: 0x00D371A0
		public Dictionary<int, IWorldMapNavigate> AreaMap { get; set; } = new Dictionary<int, IWorldMapNavigate>();
	}
}
