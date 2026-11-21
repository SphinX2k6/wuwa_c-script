using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004543 RID: 17731
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateCountryData : IWorldMapNavigateCountryData
	{
		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x0602CB0C RID: 183052 RVA: 0x00C86ADB File Offset: 0x00C84CDB
		// (set) Token: 0x0602CB0D RID: 183053 RVA: 0x00C86AE3 File Offset: 0x00C84CE3
		public int CountryId { get; set; }

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x0602CB0E RID: 183054 RVA: 0x00C86AEC File Offset: 0x00C84CEC
		// (set) Token: 0x0602CB0F RID: 183055 RVA: 0x00C86AF4 File Offset: 0x00C84CF4
		public IWorldMapNavigateCountry NavigateCountry { get; set; }
	}
}
