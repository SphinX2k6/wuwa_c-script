using System;

// Token: 0x02002416 RID: 9238
public class PhantomManagerConfigNewSettingInfo : IPhantomManagerConfigNewSettingInfo
{
	// Token: 0x170017E9 RID: 6121
	// (get) Token: 0x060127E5 RID: 75749 RVA: 0x0048F411 File Offset: 0x0048D611
	// (set) Token: 0x060127E6 RID: 75750 RVA: 0x0048F419 File Offset: 0x0048D619
	public int FetterId { get; set; }

	// Token: 0x170017EA RID: 6122
	// (get) Token: 0x060127E7 RID: 75751 RVA: 0x0048F422 File Offset: 0x0048D622
	// (set) Token: 0x060127E8 RID: 75752 RVA: 0x0048F42A File Offset: 0x0048D62A
	public int Cost { get; set; }

	// Token: 0x170017EB RID: 6123
	// (get) Token: 0x060127E9 RID: 75753 RVA: 0x0048F433 File Offset: 0x0048D633
	// (set) Token: 0x060127EA RID: 75754 RVA: 0x0048F43B File Offset: 0x0048D63B
	public int Count { get; set; }

	// Token: 0x170017EC RID: 6124
	// (get) Token: 0x060127EB RID: 75755 RVA: 0x0048F444 File Offset: 0x0048D644
	// (set) Token: 0x060127EC RID: 75756 RVA: 0x0048F44C File Offset: 0x0048D64C
	public int ItemId { get; set; }

	// Token: 0x170017ED RID: 6125
	// (get) Token: 0x060127ED RID: 75757 RVA: 0x0048F455 File Offset: 0x0048D655
	// (set) Token: 0x060127EE RID: 75758 RVA: 0x0048F45D File Offset: 0x0048D65D
	public bool IsEdit { get; set; }
}
