using System;
using System.Runtime.CompilerServices;

// Token: 0x02001600 RID: 5632
[NullableContext(1)]
[Nullable(0)]
public class UiInteractChatLogEvent : PlayerCommonLogData
{
	// Token: 0x170014FC RID: 5372
	// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x004180C8 File Offset: 0x004162C8
	// (set) Token: 0x0600DE28 RID: 56872 RVA: 0x004180D0 File Offset: 0x004162D0
	public override string event_id { get; set; } = "1809";

	// Token: 0x04007E26 RID: 32294
	public int i_old_count;

	// Token: 0x04007E27 RID: 32295
	public int i_new_count;

	// Token: 0x04007E28 RID: 32296
	public int i_inst_id;

	// Token: 0x04007E29 RID: 32297
	public double i_cost_time;

	// Token: 0x04007E2A RID: 32298
	public long i_skill_id;
}
