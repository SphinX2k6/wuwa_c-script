using System;
using System.Runtime.CompilerServices;

// Token: 0x02002158 RID: 8536
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRewardClearReport : PlayerCommonLogData
{
	// Token: 0x170014FB RID: 5371
	// (get) Token: 0x06010A3E RID: 68158 RVA: 0x0040C11F File Offset: 0x0040A31F
	// (set) Token: 0x06010A3F RID: 68159 RVA: 0x0040C127 File Offset: 0x0040A327
	public override string event_id { get; set; } = "1841";

	// Token: 0x04007E07 RID: 32263
	public int i_activity_id;

	// Token: 0x04007E08 RID: 32264
	public int i_round;

	// Token: 0x04007E09 RID: 32265
	public int i_step_id;

	// Token: 0x04007E0A RID: 32266
	public int i_way;
}
