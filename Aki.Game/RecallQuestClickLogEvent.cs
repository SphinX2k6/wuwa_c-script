using System;
using System.Runtime.CompilerServices;

// Token: 0x02001657 RID: 5719
[NullableContext(1)]
[Nullable(0)]
public class RecallQuestClickLogEvent : PlayerCommonLogData
{
	// Token: 0x1700154C RID: 5452
	// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x00418E57 File Offset: 0x00417057
	// (set) Token: 0x0600DF1F RID: 57119 RVA: 0x00418E5F File Offset: 0x0041705F
	public override string event_id { get; set; } = "2007";

	// Token: 0x04007FD6 RID: 32726
	public int i_recall_id;

	// Token: 0x04007FD7 RID: 32727
	public int i_result;
}
