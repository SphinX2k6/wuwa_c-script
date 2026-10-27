using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002169 RID: 8553
[NullableContext(1)]
[Nullable(0)]
public class SheriffReasoningCompleteEvent : PlayerCommonLogData
{
	// Token: 0x1700150B RID: 5387
	// (get) Token: 0x06010A6F RID: 68207 RVA: 0x0040C3B4 File Offset: 0x0040A5B4
	// (set) Token: 0x06010A70 RID: 68208 RVA: 0x0040C3BC File Offset: 0x0040A5BC
	public override string event_id { get; set; } = "1920";

	// Token: 0x04007E53 RID: 32339
	public int i_quest_id;

	// Token: 0x04007E54 RID: 32340
	public int i_question_id;

	// Token: 0x04007E55 RID: 32341
	public int i_result_id;

	// Token: 0x04007E56 RID: 32342
	[Nullable(2)]
	public List<int> o_clue_id;
}
