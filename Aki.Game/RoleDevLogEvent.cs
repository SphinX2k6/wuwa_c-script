using System;
using System.Runtime.CompilerServices;

// Token: 0x02001601 RID: 5633
[NullableContext(1)]
[Nullable(0)]
public class RoleDevLogEvent : PlayerCommonLogData
{
	// Token: 0x170014FD RID: 5373
	// (get) Token: 0x0600DE2A RID: 56874 RVA: 0x004180EC File Offset: 0x004162EC
	// (set) Token: 0x0600DE2B RID: 56875 RVA: 0x004180F4 File Offset: 0x004162F4
	public override string event_id { get; set; } = "1807";

	// Token: 0x04007E2C RID: 32300
	public int i_role_id;

	// Token: 0x04007E2D RID: 32301
	public int i_role_type;

	// Token: 0x04007E2E RID: 32302
	public int i_main_page;

	// Token: 0x04007E2F RID: 32303
	public int i_sub_page;

	// Token: 0x04007E30 RID: 32304
	public int i_type;

	// Token: 0x04007E31 RID: 32305
	public int i_status;

	// Token: 0x04007E32 RID: 32306
	public int i_core;
}
