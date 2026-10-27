using System;
using System.Runtime.CompilerServices;

// Token: 0x0200213B RID: 8507
[NullableContext(1)]
[Nullable(0)]
public class SubPackageOutOfSpaceLogEvent : CommonLogData
{
	// Token: 0x170014E1 RID: 5345
	// (get) Token: 0x060109ED RID: 68077 RVA: 0x0040BC63 File Offset: 0x00409E63
	// (set) Token: 0x060109EE RID: 68078 RVA: 0x0040BC6B File Offset: 0x00409E6B
	public override string event_id { get; set; } = "1707";

	// Token: 0x04007D65 RID: 32101
	public string s_suit_name = "";

	// Token: 0x04007D66 RID: 32102
	public int i_resource_type;

	// Token: 0x04007D67 RID: 32103
	public bool b_if_storage_alert;

	// Token: 0x04007D68 RID: 32104
	public int i_required_space;

	// Token: 0x04007D69 RID: 32105
	public int i_remaining_space;

	// Token: 0x04007D6A RID: 32106
	public int i_role_id;
}
