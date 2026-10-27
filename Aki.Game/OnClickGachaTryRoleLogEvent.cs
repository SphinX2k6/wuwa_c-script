using System;
using System.Runtime.CompilerServices;

// Token: 0x020020EE RID: 8430
[NullableContext(1)]
[Nullable(0)]
public class OnClickGachaTryRoleLogEvent : PlayerCommonLogData
{
	// Token: 0x17001494 RID: 5268
	// (get) Token: 0x06010906 RID: 67846 RVA: 0x0040AF5B File Offset: 0x0040915B
	// (set) Token: 0x06010907 RID: 67847 RVA: 0x0040AF63 File Offset: 0x00409163
	public override string event_id { get; set; } = "1824";

	// Token: 0x04007C2B RID: 31787
	public int i_gacha_id;

	// Token: 0x04007C2C RID: 31788
	public int i_role_id;
}
