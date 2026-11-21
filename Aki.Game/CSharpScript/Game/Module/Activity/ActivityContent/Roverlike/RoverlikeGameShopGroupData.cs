using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D3 RID: 20691
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGameShopGroupData : IRoverlikeGameShopGroupData
	{
		// Token: 0x17006511 RID: 25873
		// (get) Token: 0x06033C7A RID: 212090 RVA: 0x00E7E038 File Offset: 0x00E7C238
		// (set) Token: 0x06033C7B RID: 212091 RVA: 0x00E7E040 File Offset: 0x00E7C240
		public ERoverlikeGameShopItemType GroupType { get; set; }

		// Token: 0x17006512 RID: 25874
		// (get) Token: 0x06033C7C RID: 212092 RVA: 0x00E7E049 File Offset: 0x00E7C249
		// (set) Token: 0x06033C7D RID: 212093 RVA: 0x00E7E051 File Offset: 0x00E7C251
		public string TitleTextKey { get; set; }

		// Token: 0x17006513 RID: 25875
		// (get) Token: 0x06033C7E RID: 212094 RVA: 0x00E7E05A File Offset: 0x00E7C25A
		// (set) Token: 0x06033C7F RID: 212095 RVA: 0x00E7E062 File Offset: 0x00E7C262
		public List<IRoverlikeGameShopGridData> Grids { get; set; }
	}
}
