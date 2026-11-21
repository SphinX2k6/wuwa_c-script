using System;

// Token: 0x020005EA RID: 1514
public interface IBabelTowerBuffItemData
{
	// Token: 0x17000A09 RID: 2569
	// (get) Token: 0x0600473F RID: 18239
	// (set) Token: 0x06004740 RID: 18240
	int Id { get; set; }

	// Token: 0x17000A0A RID: 2570
	// (get) Token: 0x06004741 RID: 18241
	// (set) Token: 0x06004742 RID: 18242
	bool IsDeTerm { get; set; }

	// Token: 0x17000A0B RID: 2571
	// (get) Token: 0x06004743 RID: 18243
	// (set) Token: 0x06004744 RID: 18244
	bool CanClick { get; set; }

	// Token: 0x17000A0C RID: 2572
	// (get) Token: 0x06004745 RID: 18245
	// (set) Token: 0x06004746 RID: 18246
	bool? ShowStar { get; set; }

	// Token: 0x17000A0D RID: 2573
	// (get) Token: 0x06004747 RID: 18247
	// (set) Token: 0x06004748 RID: 18248
	bool? IsNecessary { get; set; }

	// Token: 0x17000A0E RID: 2574
	// (get) Token: 0x06004749 RID: 18249
	// (set) Token: 0x0600474A RID: 18250
	bool? IsLock { get; set; }

	// Token: 0x17000A0F RID: 2575
	// (get) Token: 0x0600474B RID: 18251
	// (set) Token: 0x0600474C RID: 18252
	bool? IsSelect { get; set; }

	// Token: 0x17000A10 RID: 2576
	// (get) Token: 0x0600474D RID: 18253
	// (set) Token: 0x0600474E RID: 18254
	int? GroupId { get; set; }
}
