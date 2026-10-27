using System;

// Token: 0x02001136 RID: 4406
public interface IBabelTowerBuffItemData
{
	// Token: 0x170009E9 RID: 2537
	// (get) Token: 0x060073A8 RID: 29608
	// (set) Token: 0x060073A9 RID: 29609
	int Id { get; set; }

	// Token: 0x170009EA RID: 2538
	// (get) Token: 0x060073AA RID: 29610
	// (set) Token: 0x060073AB RID: 29611
	bool IsDeTerm { get; set; }

	// Token: 0x170009EB RID: 2539
	// (get) Token: 0x060073AC RID: 29612
	// (set) Token: 0x060073AD RID: 29613
	bool CanClick { get; set; }

	// Token: 0x170009EC RID: 2540
	// (get) Token: 0x060073AE RID: 29614
	// (set) Token: 0x060073AF RID: 29615
	bool? ShowStar { get; set; }

	// Token: 0x170009ED RID: 2541
	// (get) Token: 0x060073B0 RID: 29616
	// (set) Token: 0x060073B1 RID: 29617
	bool? IsNecessary { get; set; }

	// Token: 0x170009EE RID: 2542
	// (get) Token: 0x060073B2 RID: 29618
	// (set) Token: 0x060073B3 RID: 29619
	bool? IsLock { get; set; }

	// Token: 0x170009EF RID: 2543
	// (get) Token: 0x060073B4 RID: 29620
	// (set) Token: 0x060073B5 RID: 29621
	bool? IsSelect { get; set; }

	// Token: 0x170009F0 RID: 2544
	// (get) Token: 0x060073B6 RID: 29622
	// (set) Token: 0x060073B7 RID: 29623
	int? GroupId { get; set; }
}
