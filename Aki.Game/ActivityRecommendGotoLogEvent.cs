using System;
using System.Runtime.CompilerServices;

// Token: 0x02002123 RID: 8483
[NullableContext(1)]
[Nullable(0)]
public class ActivityRecommendGotoLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C9 RID: 5321
	// (get) Token: 0x060109A5 RID: 68005 RVA: 0x0040B8CC File Offset: 0x00409ACC
	// (set) Token: 0x060109A6 RID: 68006 RVA: 0x0040B8D4 File Offset: 0x00409AD4
	public override string event_id { get; set; } = "2006";

	// Token: 0x04007D09 RID: 32009
	public int i_task_type;

	// Token: 0x04007D0A RID: 32010
	public int i_goto_id;
}
