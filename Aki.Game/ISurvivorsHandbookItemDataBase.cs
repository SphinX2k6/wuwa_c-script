using System;

// Token: 0x02002B98 RID: 11160
public interface ISurvivorsHandbookItemDataBase
{
	// Token: 0x17001F21 RID: 7969
	// (get) Token: 0x060171F9 RID: 94713
	int Id { get; }

	// Token: 0x17001F22 RID: 7970
	// (get) Token: 0x060171FA RID: 94714
	bool? LockState { get; }

	// Token: 0x17001F23 RID: 7971
	// (get) Token: 0x060171FB RID: 94715
	// (set) Token: 0x060171FC RID: 94716
	bool? IsNew { get; set; }
}
