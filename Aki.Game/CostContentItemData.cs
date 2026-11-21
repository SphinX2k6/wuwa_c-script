using System;

// Token: 0x02001DF6 RID: 7670
public class CostContentItemData : ICostContentItemData
{
	// Token: 0x17001CCC RID: 7372
	// (get) Token: 0x06012F26 RID: 77606 RVA: 0x0058D328 File Offset: 0x0058B528
	// (set) Token: 0x06012F27 RID: 77607 RVA: 0x0058D330 File Offset: 0x0058B530
	public int CostNum { get; set; }

	// Token: 0x17001CCD RID: 7373
	// (get) Token: 0x06012F28 RID: 77608 RVA: 0x0058D339 File Offset: 0x0058B539
	// (set) Token: 0x06012F29 RID: 77609 RVA: 0x0058D341 File Offset: 0x0058B541
	public EItemId CostType { get; set; }
}
