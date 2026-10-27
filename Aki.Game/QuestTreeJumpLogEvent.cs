using System;
using System.Runtime.CompilerServices;

// Token: 0x02002132 RID: 8498
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeJumpLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D8 RID: 5336
	// (get) Token: 0x060109D2 RID: 68050 RVA: 0x0040BAFE File Offset: 0x00409CFE
	// (set) Token: 0x060109D3 RID: 68051 RVA: 0x0040BB06 File Offset: 0x00409D06
	public override string event_id { get; set; } = "1918";

	// Token: 0x04007D3B RID: 32059
	public int i_chapter_id;

	// Token: 0x04007D3C RID: 32060
	public int i_quest_id;

	// Token: 0x04007D3D RID: 32061
	public int i_quest_status;

	// Token: 0x04007D3E RID: 32062
	public int i_quest_type;

	// Token: 0x04007D3F RID: 32063
	public int i_motion;
}
