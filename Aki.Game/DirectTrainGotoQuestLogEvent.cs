using System;
using System.Runtime.CompilerServices;

// Token: 0x02001650 RID: 5712
[NullableContext(1)]
[Nullable(0)]
public class DirectTrainGotoQuestLogEvent : PlayerCommonLogData
{
	// Token: 0x17001545 RID: 5445
	// (get) Token: 0x0600DF09 RID: 57097 RVA: 0x00418D45 File Offset: 0x00416F45
	// (set) Token: 0x0600DF0A RID: 57098 RVA: 0x00418D4D File Offset: 0x00416F4D
	public override string event_id { get; set; } = "1113";

	// Token: 0x04007FA3 RID: 32675
	public int i_activity_id;

	// Token: 0x04007FA4 RID: 32676
	public int i_id;

	// Token: 0x04007FA5 RID: 32677
	public int i_quest_id;

	// Token: 0x04007FA6 RID: 32678
	public int i_if_finish;
}
