using System;
using System.Runtime.CompilerServices;

// Token: 0x02002177 RID: 8567
[NullableContext(1)]
[Nullable(0)]
public class DirectTrainOpenModuleLogEvent : PlayerCommonLogData
{
	// Token: 0x17001516 RID: 5398
	// (get) Token: 0x06010A93 RID: 68243 RVA: 0x0040C5D9 File Offset: 0x0040A7D9
	// (set) Token: 0x06010A94 RID: 68244 RVA: 0x0040C5E1 File Offset: 0x0040A7E1
	public override string event_id { get; set; } = "1112";

	// Token: 0x04007E8D RID: 32397
	public int i_activity_id;

	// Token: 0x04007E8E RID: 32398
	public int i_id;

	// Token: 0x04007E8F RID: 32399
	public int i_quest_id;

	// Token: 0x04007E90 RID: 32400
	public int i_if_finish;

	// Token: 0x04007E91 RID: 32401
	public int i_unlock;
}
