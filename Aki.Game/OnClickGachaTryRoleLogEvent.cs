using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C5 RID: 5573
[NullableContext(1)]
[Nullable(0)]
public class OnClickGachaTryRoleLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C1 RID: 5313
	// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x0041766B File Offset: 0x0041586B
	// (set) Token: 0x0600DD77 RID: 56695 RVA: 0x00417673 File Offset: 0x00415873
	public override string event_id { get; set; } = "1824";

	// Token: 0x04007D2A RID: 32042
	public int i_gacha_id;

	// Token: 0x04007D2B RID: 32043
	public int i_role_id;
}
