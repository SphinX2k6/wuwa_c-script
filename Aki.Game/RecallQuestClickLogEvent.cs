using System;
using System.Runtime.CompilerServices;

// Token: 0x0200217F RID: 8575
[NullableContext(1)]
[Nullable(0)]
public class RecallQuestClickLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151E RID: 5406
	// (get) Token: 0x06010AAB RID: 68267 RVA: 0x0040C70F File Offset: 0x0040A90F
	// (set) Token: 0x06010AAC RID: 68268 RVA: 0x0040C717 File Offset: 0x0040A917
	public override string event_id { get; set; } = "2007";

	// Token: 0x04007EC6 RID: 32454
	public int i_recall_id;

	// Token: 0x04007EC7 RID: 32455
	public int i_result;
}
