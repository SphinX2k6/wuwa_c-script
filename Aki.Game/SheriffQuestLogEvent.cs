using System;
using System.Runtime.CompilerServices;

// Token: 0x02001640 RID: 5696
[NullableContext(1)]
[Nullable(0)]
public class SheriffQuestLogEvent : PlayerCommonLogData
{
	// Token: 0x17001538 RID: 5432
	// (get) Token: 0x0600DEDF RID: 57055 RVA: 0x00418AD8 File Offset: 0x00416CD8
	// (set) Token: 0x0600DEE0 RID: 57056 RVA: 0x00418AE0 File Offset: 0x00416CE0
	public override string event_id { get; set; } = "1930";

	// Token: 0x04007F5F RID: 32607
	public int i_area_id;

	// Token: 0x04007F60 RID: 32608
	public int i_quest_id;

	// Token: 0x04007F61 RID: 32609
	public int i_quest_status;
}
