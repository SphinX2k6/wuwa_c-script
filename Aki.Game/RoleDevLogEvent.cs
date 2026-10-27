using System;
using System.Runtime.CompilerServices;

// Token: 0x02002129 RID: 8489
[NullableContext(1)]
[Nullable(0)]
public class RoleDevLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CF RID: 5327
	// (get) Token: 0x060109B7 RID: 68023 RVA: 0x0040B9A4 File Offset: 0x00409BA4
	// (set) Token: 0x060109B8 RID: 68024 RVA: 0x0040B9AC File Offset: 0x00409BAC
	public override string event_id { get; set; } = "1807";

	// Token: 0x04007D1E RID: 32030
	public int i_role_id;

	// Token: 0x04007D1F RID: 32031
	public int i_role_type;

	// Token: 0x04007D20 RID: 32032
	public int i_main_page;

	// Token: 0x04007D21 RID: 32033
	public int i_sub_page;

	// Token: 0x04007D22 RID: 32034
	public int i_type;
}
