using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B4 RID: 5556
[NullableContext(1)]
[Nullable(0)]
public class TotalTopUpVideoOpenLogData : PlayerCommonLogData
{
	// Token: 0x170014B2 RID: 5298
	// (get) Token: 0x0600DD47 RID: 56647 RVA: 0x004173F2 File Offset: 0x004155F2
	// (set) Token: 0x0600DD48 RID: 56648 RVA: 0x004173FA File Offset: 0x004155FA
	public override string event_id { get; set; } = "1944";

	// Token: 0x04007CEF RID: 31983
	public int i_activity_id;

	// Token: 0x04007CF0 RID: 31984
	public int i_reward_id;
}
