using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D7 RID: 14039
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaExploreInfoData : IAreaExploreInfoData
	{
		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x0602477A RID: 149370 RVA: 0x00A4B785 File Offset: 0x00A49985
		// (set) Token: 0x0602477B RID: 149371 RVA: 0x00A4B78D File Offset: 0x00A4998D
		public int AreaId { get; set; }

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x0602477C RID: 149372 RVA: 0x00A4B796 File Offset: 0x00A49996
		// (set) Token: 0x0602477D RID: 149373 RVA: 0x00A4B79E File Offset: 0x00A4999E
		public List<IOneExploreItemData> ExploreProgress { get; set; } = new List<IOneExploreItemData>();

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x0602477E RID: 149374 RVA: 0x00A4B7A7 File Offset: 0x00A499A7
		// (set) Token: 0x0602477F RID: 149375 RVA: 0x00A4B7AF File Offset: 0x00A499AF
		public float ExplorePercent { get; set; }
	}
}
