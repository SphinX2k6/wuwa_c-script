using System;
using System.Runtime.CompilerServices;

// Token: 0x0200160E RID: 5646
[NullableContext(1)]
[Nullable(0)]
public class ActivityPreWarmStayLogEvent : PlayerCommonLogData
{
	// Token: 0x1700150A RID: 5386
	// (get) Token: 0x0600DE51 RID: 56913 RVA: 0x004182E1 File Offset: 0x004164E1
	// (set) Token: 0x0600DE52 RID: 56914 RVA: 0x004182E9 File Offset: 0x004164E9
	public override string event_id { get; set; } = "1812";

	// Token: 0x04007E59 RID: 32345
	public int i_activity_id;

	// Token: 0x04007E5A RID: 32346
	public int i_chapter_id;

	// Token: 0x04007E5B RID: 32347
	public double i_cost_time;
}
