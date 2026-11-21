using System;
using System.Runtime.CompilerServices;

// Token: 0x0200160A RID: 5642
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeJumpLogEvent : PlayerCommonLogData
{
	// Token: 0x17001506 RID: 5382
	// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x00418246 File Offset: 0x00416446
	// (set) Token: 0x0600DE46 RID: 56902 RVA: 0x0041824E File Offset: 0x0041644E
	public override string event_id { get; set; } = "1918";

	// Token: 0x04007E4B RID: 32331
	public int i_chapter_id;

	// Token: 0x04007E4C RID: 32332
	public int i_quest_id;

	// Token: 0x04007E4D RID: 32333
	public int i_quest_status;

	// Token: 0x04007E4E RID: 32334
	public int i_quest_type;

	// Token: 0x04007E4F RID: 32335
	public int i_motion;
}
