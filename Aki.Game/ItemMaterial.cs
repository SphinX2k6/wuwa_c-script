using System;

// Token: 0x02001D5B RID: 7515
public class ItemMaterial : IItemMaterial
{
	// Token: 0x17001BBC RID: 7100
	// (get) Token: 0x06012965 RID: 76133 RVA: 0x0057BEAE File Offset: 0x0057A0AE
	// (set) Token: 0x06012966 RID: 76134 RVA: 0x0057BEB6 File Offset: 0x0057A0B6
	public int ItemId { get; set; }

	// Token: 0x17001BBD RID: 7101
	// (get) Token: 0x06012967 RID: 76135 RVA: 0x0057BEBF File Offset: 0x0057A0BF
	// (set) Token: 0x06012968 RID: 76136 RVA: 0x0057BEC7 File Offset: 0x0057A0C7
	public int RequiredCount { get; set; }
}
