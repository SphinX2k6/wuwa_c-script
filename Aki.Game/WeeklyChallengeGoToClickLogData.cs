using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B9 RID: 5561
[NullableContext(1)]
[Nullable(0)]
public class WeeklyChallengeGoToClickLogData : PlayerCommonLogData
{
	// Token: 0x170014B7 RID: 5303
	// (get) Token: 0x0600DD56 RID: 56662 RVA: 0x004174A6 File Offset: 0x004156A6
	// (set) Token: 0x0600DD57 RID: 56663 RVA: 0x004174AE File Offset: 0x004156AE
	public override string event_id { get; set; } = "1031";

	// Token: 0x04007D02 RID: 32002
	public int i_activity_id;

	// Token: 0x04007D03 RID: 32003
	public int i_activity_type;

	// Token: 0x04007D04 RID: 32004
	public int i_unlock;
}
