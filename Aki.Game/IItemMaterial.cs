using System;

// Token: 0x020027DF RID: 10207
public interface IItemMaterial
{
	// Token: 0x17001B62 RID: 7010
	// (get) Token: 0x06014F61 RID: 85857
	// (set) Token: 0x06014F62 RID: 85858
	int ItemId { get; set; }

	// Token: 0x17001B63 RID: 7011
	// (get) Token: 0x06014F63 RID: 85859
	// (set) Token: 0x06014F64 RID: 85860
	int RequiredCount { get; set; }
}
