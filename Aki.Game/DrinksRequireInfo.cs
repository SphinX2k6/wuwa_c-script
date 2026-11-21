using System;

// Token: 0x020003F5 RID: 1013
public class DrinksRequireInfo : IDrinksRequireInfo
{
	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x0600372C RID: 14124 RVA: 0x0014233C File Offset: 0x0014053C
	// (set) Token: 0x0600372D RID: 14125 RVA: 0x00142344 File Offset: 0x00140544
	public int RequireId { get; set; }

	// Token: 0x170007C6 RID: 1990
	// (get) Token: 0x0600372E RID: 14126 RVA: 0x0014234D File Offset: 0x0014054D
	// (set) Token: 0x0600372F RID: 14127 RVA: 0x00142355 File Offset: 0x00140555
	public EDrinksRequireType Type { get; set; }

	// Token: 0x170007C7 RID: 1991
	// (get) Token: 0x06003730 RID: 14128 RVA: 0x0014235E File Offset: 0x0014055E
	// (set) Token: 0x06003731 RID: 14129 RVA: 0x00142366 File Offset: 0x00140566
	public int? FlavorRangeId { get; set; }

	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x06003732 RID: 14130 RVA: 0x0014236F File Offset: 0x0014056F
	// (set) Token: 0x06003733 RID: 14131 RVA: 0x00142377 File Offset: 0x00140577
	public bool Completed { get; set; }
}
