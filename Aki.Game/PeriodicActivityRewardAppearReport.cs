using System;
using System.Runtime.CompilerServices;

// Token: 0x02002157 RID: 8535
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRewardAppearReport : PlayerCommonLogData
{
	// Token: 0x170014FA RID: 5370
	// (get) Token: 0x06010A3B RID: 68155 RVA: 0x0040C0FB File Offset: 0x0040A2FB
	// (set) Token: 0x06010A3C RID: 68156 RVA: 0x0040C103 File Offset: 0x0040A303
	public override string event_id { get; set; } = "1840";

	// Token: 0x04007E03 RID: 32259
	public int i_activity_id;

	// Token: 0x04007E04 RID: 32260
	public int i_round;

	// Token: 0x04007E05 RID: 32261
	public int i_step_id;
}
