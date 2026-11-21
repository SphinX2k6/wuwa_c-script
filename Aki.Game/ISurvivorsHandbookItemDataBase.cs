using System;

// Token: 0x02002114 RID: 8468
public interface ISurvivorsHandbookItemDataBase
{
	// Token: 0x17001F79 RID: 8057
	// (get) Token: 0x06014C2A RID: 85034
	int Id { get; }

	// Token: 0x17001F7A RID: 8058
	// (get) Token: 0x06014C2B RID: 85035
	bool? LockState { get; }

	// Token: 0x17001F7B RID: 8059
	// (get) Token: 0x06014C2C RID: 85036
	// (set) Token: 0x06014C2D RID: 85037
	bool? IsNew { get; set; }
}
