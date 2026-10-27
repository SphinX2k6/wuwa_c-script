using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200215D RID: 8541
[NullableContext(1)]
[Nullable(0)]
public class PhantomDiscardLockPlanReport : PlayerCommonLogData
{
	// Token: 0x170014FF RID: 5375
	// (get) Token: 0x06010A4B RID: 68171 RVA: 0x0040C1C2 File Offset: 0x0040A3C2
	// (set) Token: 0x06010A4C RID: 68172 RVA: 0x0040C1CA File Offset: 0x0040A3CA
	public override string event_id { get; set; } = "1845";

	// Token: 0x04007E16 RID: 32278
	public int i_suit_id;

	// Token: 0x04007E17 RID: 32279
	public int i_success;

	// Token: 0x04007E18 RID: 32280
	public int i_type;

	// Token: 0x04007E19 RID: 32281
	public int i_if_finish;

	// Token: 0x04007E1A RID: 32282
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PhantomDiscardPlanPlanLogData> o_setting_plan;
}
