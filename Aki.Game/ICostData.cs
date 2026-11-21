using System;

// Token: 0x020014EC RID: 5356
public interface ICostData
{
	// Token: 0x170013D6 RID: 5078
	// (get) Token: 0x0600D61B RID: 54811
	// (set) Token: 0x0600D61C RID: 54812
	int ItemId { get; set; }

	// Token: 0x170013D7 RID: 5079
	// (get) Token: 0x0600D61D RID: 54813
	// (set) Token: 0x0600D61E RID: 54814
	int Count { get; set; }

	// Token: 0x170013D8 RID: 5080
	// (get) Token: 0x0600D61F RID: 54815
	// (set) Token: 0x0600D620 RID: 54816
	int Cost { get; set; }
}
