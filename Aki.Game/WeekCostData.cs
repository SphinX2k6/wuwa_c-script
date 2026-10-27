using System;
using System.Runtime.CompilerServices;

// Token: 0x020023A3 RID: 9123
[NullableContext(1)]
[Nullable(0)]
public class WeekCostData : IWeekCostData
{
	// Token: 0x170017AC RID: 6060
	// (get) Token: 0x060123F1 RID: 74737 RVA: 0x0047E755 File Offset: 0x0047C955
	// (set) Token: 0x060123F2 RID: 74738 RVA: 0x0047E75D File Offset: 0x0047C95D
	public string Tips { get; set; }

	// Token: 0x170017AD RID: 6061
	// (get) Token: 0x060123F3 RID: 74739 RVA: 0x0047E766 File Offset: 0x0047C966
	// (set) Token: 0x060123F4 RID: 74740 RVA: 0x0047E76E File Offset: 0x0047C96E
	public int ItemId { get; set; }

	// Token: 0x170017AE RID: 6062
	// (get) Token: 0x060123F5 RID: 74741 RVA: 0x0047E777 File Offset: 0x0047C977
	// (set) Token: 0x060123F6 RID: 74742 RVA: 0x0047E77F File Offset: 0x0047C97F
	public int Count { get; set; }
}
