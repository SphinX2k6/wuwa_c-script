using System;

// Token: 0x020027E0 RID: 10208
public class ItemMaterial : IItemMaterial
{
	// Token: 0x17001B64 RID: 7012
	// (get) Token: 0x06014F65 RID: 85861 RVA: 0x0055113E File Offset: 0x0054F33E
	// (set) Token: 0x06014F66 RID: 85862 RVA: 0x00551146 File Offset: 0x0054F346
	public int ItemId { get; set; }

	// Token: 0x17001B65 RID: 7013
	// (get) Token: 0x06014F67 RID: 85863 RVA: 0x0055114F File Offset: 0x0054F34F
	// (set) Token: 0x06014F68 RID: 85864 RVA: 0x00551157 File Offset: 0x0054F357
	public int RequiredCount { get; set; }
}
