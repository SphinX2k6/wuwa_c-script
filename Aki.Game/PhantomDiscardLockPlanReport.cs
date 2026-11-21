using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001635 RID: 5685
[NullableContext(1)]
[Nullable(0)]
public class PhantomDiscardLockPlanReport : PlayerCommonLogData
{
	// Token: 0x1700152D RID: 5421
	// (get) Token: 0x0600DEBE RID: 57022 RVA: 0x0041890A File Offset: 0x00416B0A
	// (set) Token: 0x0600DEBF RID: 57023 RVA: 0x00418912 File Offset: 0x00416B12
	public override string event_id { get; set; } = "1845";

	// Token: 0x04007F26 RID: 32550
	public int i_suit_id;

	// Token: 0x04007F27 RID: 32551
	public int i_success;

	// Token: 0x04007F28 RID: 32552
	public int i_type;

	// Token: 0x04007F29 RID: 32553
	public int i_if_finish;

	// Token: 0x04007F2A RID: 32554
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PhantomDiscardPlanPlanLogData> o_setting_plan;
}
