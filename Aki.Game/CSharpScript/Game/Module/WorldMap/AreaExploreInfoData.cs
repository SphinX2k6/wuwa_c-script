using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047A6 RID: 18342
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaExploreInfoData : IAreaExploreInfoData
	{
		// Token: 0x1700782B RID: 30763
		// (get) Token: 0x0602FFAD RID: 196525 RVA: 0x00B1B7E9 File Offset: 0x00B199E9
		// (set) Token: 0x0602FFAE RID: 196526 RVA: 0x00B1B7F1 File Offset: 0x00B199F1
		public int AreaId { get; set; }

		// Token: 0x1700782C RID: 30764
		// (get) Token: 0x0602FFAF RID: 196527 RVA: 0x00B1B7FA File Offset: 0x00B199FA
		// (set) Token: 0x0602FFB0 RID: 196528 RVA: 0x00B1B802 File Offset: 0x00B19A02
		public List<IOneExploreItemData> ExploreProgress { get; set; } = new List<IOneExploreItemData>();

		// Token: 0x1700782D RID: 30765
		// (get) Token: 0x0602FFB1 RID: 196529 RVA: 0x00B1B80B File Offset: 0x00B19A0B
		// (set) Token: 0x0602FFB2 RID: 196530 RVA: 0x00B1B813 File Offset: 0x00B19A13
		public float ExplorePercent { get; set; }
	}
}
