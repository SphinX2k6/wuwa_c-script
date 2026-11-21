using System;
using System.Runtime.CompilerServices;

// Token: 0x020015CB RID: 5579
[NullableContext(1)]
[Nullable(0)]
public class RoleSpineButtonClickLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C7 RID: 5319
	// (get) Token: 0x0600DD88 RID: 56712 RVA: 0x00417743 File Offset: 0x00415943
	// (set) Token: 0x0600DD89 RID: 56713 RVA: 0x0041774B File Offset: 0x0041594B
	public override string event_id { get; set; } = "1074";

	// Token: 0x04007D3C RID: 32060
	public int i_role_id;

	// Token: 0x04007D3D RID: 32061
	public int i_skin_id;
}
