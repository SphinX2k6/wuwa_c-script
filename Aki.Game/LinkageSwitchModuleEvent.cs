using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D6 RID: 5590
[NullableContext(1)]
[Nullable(0)]
public class LinkageSwitchModuleEvent : PlayerCommonLogData
{
	// Token: 0x170014D2 RID: 5330
	// (get) Token: 0x0600DDA9 RID: 56745 RVA: 0x004178E5 File Offset: 0x00415AE5
	// (set) Token: 0x0600DDAA RID: 56746 RVA: 0x004178ED File Offset: 0x00415AED
	public override string event_id { get; set; } = "1058";

	// Token: 0x04007D62 RID: 32098
	public int i_activity_id;

	// Token: 0x04007D63 RID: 32099
	public int i_activity_type;

	// Token: 0x04007D64 RID: 32100
	public int i_id;

	// Token: 0x04007D65 RID: 32101
	public int i_if_finish;
}
