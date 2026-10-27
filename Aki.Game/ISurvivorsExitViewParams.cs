using System;

// Token: 0x02002B72 RID: 11122
public interface ISurvivorsExitViewParams
{
	// Token: 0x17001EBA RID: 7866
	// (get) Token: 0x0601709D RID: 94365
	bool IsExternal { get; }

	// Token: 0x17001EBB RID: 7867
	// (get) Token: 0x0601709E RID: 94366
	int Batch { get; }

	// Token: 0x17001EBC RID: 7868
	// (get) Token: 0x0601709F RID: 94367
	int MaxBatch { get; }
}
