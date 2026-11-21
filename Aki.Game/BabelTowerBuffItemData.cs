using System;

// Token: 0x020005EB RID: 1515
public class BabelTowerBuffItemData : IBabelTowerBuffItemData
{
	// Token: 0x17000A11 RID: 2577
	// (get) Token: 0x0600474F RID: 18255 RVA: 0x00184635 File Offset: 0x00182835
	// (set) Token: 0x06004750 RID: 18256 RVA: 0x0018463D File Offset: 0x0018283D
	public int Id { get; set; }

	// Token: 0x17000A12 RID: 2578
	// (get) Token: 0x06004751 RID: 18257 RVA: 0x00184646 File Offset: 0x00182846
	// (set) Token: 0x06004752 RID: 18258 RVA: 0x0018464E File Offset: 0x0018284E
	public bool IsDeTerm { get; set; }

	// Token: 0x17000A13 RID: 2579
	// (get) Token: 0x06004753 RID: 18259 RVA: 0x00184657 File Offset: 0x00182857
	// (set) Token: 0x06004754 RID: 18260 RVA: 0x0018465F File Offset: 0x0018285F
	public bool CanClick { get; set; }

	// Token: 0x17000A14 RID: 2580
	// (get) Token: 0x06004755 RID: 18261 RVA: 0x00184668 File Offset: 0x00182868
	// (set) Token: 0x06004756 RID: 18262 RVA: 0x00184670 File Offset: 0x00182870
	public bool? ShowStar { get; set; }

	// Token: 0x17000A15 RID: 2581
	// (get) Token: 0x06004757 RID: 18263 RVA: 0x00184679 File Offset: 0x00182879
	// (set) Token: 0x06004758 RID: 18264 RVA: 0x00184681 File Offset: 0x00182881
	public bool? IsNecessary { get; set; }

	// Token: 0x17000A16 RID: 2582
	// (get) Token: 0x06004759 RID: 18265 RVA: 0x0018468A File Offset: 0x0018288A
	// (set) Token: 0x0600475A RID: 18266 RVA: 0x00184692 File Offset: 0x00182892
	public bool? IsLock { get; set; }

	// Token: 0x17000A17 RID: 2583
	// (get) Token: 0x0600475B RID: 18267 RVA: 0x0018469B File Offset: 0x0018289B
	// (set) Token: 0x0600475C RID: 18268 RVA: 0x001846A3 File Offset: 0x001828A3
	public bool? IsSelect { get; set; }

	// Token: 0x17000A18 RID: 2584
	// (get) Token: 0x0600475D RID: 18269 RVA: 0x001846AC File Offset: 0x001828AC
	// (set) Token: 0x0600475E RID: 18270 RVA: 0x001846B4 File Offset: 0x001828B4
	public int? GroupId { get; set; }
}
