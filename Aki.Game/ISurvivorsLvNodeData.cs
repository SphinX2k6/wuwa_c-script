using System;

// Token: 0x02002B60 RID: 11104
public interface ISurvivorsLvNodeData
{
	// Token: 0x17001EAD RID: 7853
	// (get) Token: 0x0601704A RID: 94282
	int Lv { get; }

	// Token: 0x17001EAE RID: 7854
	// (get) Token: 0x0601704B RID: 94283
	bool IsImportant { get; }

	// Token: 0x17001EAF RID: 7855
	// (get) Token: 0x0601704C RID: 94284
	ESurvivorsLvState State { get; }
}
