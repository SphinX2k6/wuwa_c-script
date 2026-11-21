using System;
using System.Runtime.CompilerServices;

// Token: 0x02001888 RID: 6280
[NullableContext(1)]
[Nullable(0)]
public class WeekCostData : IWeekCostData
{
	// Token: 0x170017E6 RID: 6118
	// (get) Token: 0x0600F8A3 RID: 63651 RVA: 0x0048BC29 File Offset: 0x00489E29
	// (set) Token: 0x0600F8A4 RID: 63652 RVA: 0x0048BC31 File Offset: 0x00489E31
	public string Tips { get; set; }

	// Token: 0x170017E7 RID: 6119
	// (get) Token: 0x0600F8A5 RID: 63653 RVA: 0x0048BC3A File Offset: 0x00489E3A
	// (set) Token: 0x0600F8A6 RID: 63654 RVA: 0x0048BC42 File Offset: 0x00489E42
	public int ItemId { get; set; }

	// Token: 0x170017E8 RID: 6120
	// (get) Token: 0x0600F8A7 RID: 63655 RVA: 0x0048BC4B File Offset: 0x00489E4B
	// (set) Token: 0x0600F8A8 RID: 63656 RVA: 0x0048BC53 File Offset: 0x00489E53
	public int Count { get; set; }
}
