using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B8 RID: 5560
[NullableContext(1)]
[Nullable(0)]
public class ActivityLockConditionClickLogData : PlayerCommonLogData
{
	// Token: 0x170014B6 RID: 5302
	// (get) Token: 0x0600DD53 RID: 56659 RVA: 0x00417482 File Offset: 0x00415682
	// (set) Token: 0x0600DD54 RID: 56660 RVA: 0x0041748A File Offset: 0x0041568A
	public override string event_id { get; set; } = "1029";

	// Token: 0x04007CFF RID: 31999
	public int i_activity_id;

	// Token: 0x04007D00 RID: 32000
	public int i_activity_type;
}
