using System;
using System.Runtime.CompilerServices;

// Token: 0x0200160D RID: 5645
[NullableContext(1)]
[Nullable(0)]
public class ActivityPreWarmOpenLogEvent : PlayerCommonLogData
{
	// Token: 0x17001509 RID: 5385
	// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x004182BD File Offset: 0x004164BD
	// (set) Token: 0x0600DE4F RID: 56911 RVA: 0x004182C5 File Offset: 0x004164C5
	public override string event_id { get; set; } = "1811";

	// Token: 0x04007E56 RID: 32342
	public int i_activity_id;

	// Token: 0x04007E57 RID: 32343
	public int i_chapter_id;
}
