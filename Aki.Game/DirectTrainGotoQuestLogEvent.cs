using System;
using System.Runtime.CompilerServices;

// Token: 0x02002178 RID: 8568
[NullableContext(1)]
[Nullable(0)]
public class DirectTrainGotoQuestLogEvent : PlayerCommonLogData
{
	// Token: 0x17001517 RID: 5399
	// (get) Token: 0x06010A96 RID: 68246 RVA: 0x0040C5FD File Offset: 0x0040A7FD
	// (set) Token: 0x06010A97 RID: 68247 RVA: 0x0040C605 File Offset: 0x0040A805
	public override string event_id { get; set; } = "1113";

	// Token: 0x04007E93 RID: 32403
	public int i_activity_id;

	// Token: 0x04007E94 RID: 32404
	public int i_id;

	// Token: 0x04007E95 RID: 32405
	public int i_quest_id;

	// Token: 0x04007E96 RID: 32406
	public int i_if_finish;
}
