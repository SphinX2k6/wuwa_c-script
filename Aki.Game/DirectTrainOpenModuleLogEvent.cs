using System;
using System.Runtime.CompilerServices;

// Token: 0x0200164F RID: 5711
[NullableContext(1)]
[Nullable(0)]
public class DirectTrainOpenModuleLogEvent : PlayerCommonLogData
{
	// Token: 0x17001544 RID: 5444
	// (get) Token: 0x0600DF06 RID: 57094 RVA: 0x00418D21 File Offset: 0x00416F21
	// (set) Token: 0x0600DF07 RID: 57095 RVA: 0x00418D29 File Offset: 0x00416F29
	public override string event_id { get; set; } = "1112";

	// Token: 0x04007F9D RID: 32669
	public int i_activity_id;

	// Token: 0x04007F9E RID: 32670
	public int i_id;

	// Token: 0x04007F9F RID: 32671
	public int i_quest_id;

	// Token: 0x04007FA0 RID: 32672
	public int i_if_finish;

	// Token: 0x04007FA1 RID: 32673
	public int i_unlock;
}
