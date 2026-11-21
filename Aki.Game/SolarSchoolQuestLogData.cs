using System;
using System.Runtime.CompilerServices;

// Token: 0x02001665 RID: 5733
[NullableContext(1)]
[Nullable(0)]
public class SolarSchoolQuestLogData : SolarSchoolLogData
{
	// Token: 0x17001556 RID: 5462
	// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x0041904D File Offset: 0x0041724D
	// (set) Token: 0x0600DF41 RID: 57153 RVA: 0x00419055 File Offset: 0x00417255
	public override string event_id { get; set; } = "2105";

	// Token: 0x04008032 RID: 32818
	public int i_quest_id;

	// Token: 0x04008033 RID: 32819
	public int i_result;
}
