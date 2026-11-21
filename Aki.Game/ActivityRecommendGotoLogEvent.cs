using System;
using System.Runtime.CompilerServices;

// Token: 0x020015FB RID: 5627
[NullableContext(1)]
[Nullable(0)]
public class ActivityRecommendGotoLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F7 RID: 5367
	// (get) Token: 0x0600DE18 RID: 56856 RVA: 0x00418014 File Offset: 0x00416214
	// (set) Token: 0x0600DE19 RID: 56857 RVA: 0x0041801C File Offset: 0x0041621C
	public override string event_id { get; set; } = "2006";

	// Token: 0x04007E17 RID: 32279
	public int i_task_type;

	// Token: 0x04007E18 RID: 32280
	public int i_goto_id;
}
