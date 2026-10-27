using System;
using System.Runtime.CompilerServices;

// Token: 0x020020DD RID: 8413
[NullableContext(1)]
[Nullable(0)]
public class TotalTopUpVideoOpenLogData : PlayerCommonLogData
{
	// Token: 0x17001485 RID: 5253
	// (get) Token: 0x060108D7 RID: 67799 RVA: 0x0040ACE2 File Offset: 0x00408EE2
	// (set) Token: 0x060108D8 RID: 67800 RVA: 0x0040ACEA File Offset: 0x00408EEA
	public override string event_id { get; set; } = "1944";

	// Token: 0x04007BF0 RID: 31728
	public int i_activity_id;

	// Token: 0x04007BF1 RID: 31729
	public int i_reward_id;
}
