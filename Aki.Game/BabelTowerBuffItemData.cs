using System;

// Token: 0x02001137 RID: 4407
public class BabelTowerBuffItemData : IBabelTowerBuffItemData
{
	// Token: 0x170009F1 RID: 2545
	// (get) Token: 0x060073B8 RID: 29624 RVA: 0x0017BAE7 File Offset: 0x00179CE7
	// (set) Token: 0x060073B9 RID: 29625 RVA: 0x0017BAEF File Offset: 0x00179CEF
	public int Id { get; set; }

	// Token: 0x170009F2 RID: 2546
	// (get) Token: 0x060073BA RID: 29626 RVA: 0x0017BAF8 File Offset: 0x00179CF8
	// (set) Token: 0x060073BB RID: 29627 RVA: 0x0017BB00 File Offset: 0x00179D00
	public bool IsDeTerm { get; set; }

	// Token: 0x170009F3 RID: 2547
	// (get) Token: 0x060073BC RID: 29628 RVA: 0x0017BB09 File Offset: 0x00179D09
	// (set) Token: 0x060073BD RID: 29629 RVA: 0x0017BB11 File Offset: 0x00179D11
	public bool CanClick { get; set; }

	// Token: 0x170009F4 RID: 2548
	// (get) Token: 0x060073BE RID: 29630 RVA: 0x0017BB1A File Offset: 0x00179D1A
	// (set) Token: 0x060073BF RID: 29631 RVA: 0x0017BB22 File Offset: 0x00179D22
	public bool? ShowStar { get; set; }

	// Token: 0x170009F5 RID: 2549
	// (get) Token: 0x060073C0 RID: 29632 RVA: 0x0017BB2B File Offset: 0x00179D2B
	// (set) Token: 0x060073C1 RID: 29633 RVA: 0x0017BB33 File Offset: 0x00179D33
	public bool? IsNecessary { get; set; }

	// Token: 0x170009F6 RID: 2550
	// (get) Token: 0x060073C2 RID: 29634 RVA: 0x0017BB3C File Offset: 0x00179D3C
	// (set) Token: 0x060073C3 RID: 29635 RVA: 0x0017BB44 File Offset: 0x00179D44
	public bool? IsLock { get; set; }

	// Token: 0x170009F7 RID: 2551
	// (get) Token: 0x060073C4 RID: 29636 RVA: 0x0017BB4D File Offset: 0x00179D4D
	// (set) Token: 0x060073C5 RID: 29637 RVA: 0x0017BB55 File Offset: 0x00179D55
	public bool? IsSelect { get; set; }

	// Token: 0x170009F8 RID: 2552
	// (get) Token: 0x060073C6 RID: 29638 RVA: 0x0017BB5E File Offset: 0x00179D5E
	// (set) Token: 0x060073C7 RID: 29639 RVA: 0x0017BB66 File Offset: 0x00179D66
	public int? GroupId { get; set; }
}
