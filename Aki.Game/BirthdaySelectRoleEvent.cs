using System;
using System.Runtime.CompilerServices;

// Token: 0x02002137 RID: 8503
[NullableContext(1)]
[Nullable(0)]
public class BirthdaySelectRoleEvent : PlayerCommonLogData
{
	// Token: 0x170014DD RID: 5341
	// (get) Token: 0x060109E1 RID: 68065 RVA: 0x0040BBBD File Offset: 0x00409DBD
	// (set) Token: 0x060109E2 RID: 68066 RVA: 0x0040BBC5 File Offset: 0x00409DC5
	public override string event_id { get; set; } = "1062";

	// Token: 0x04007D4D RID: 32077
	public int i_role_id;

	// Token: 0x04007D4E RID: 32078
	public bool b_if_selected_role;

	// Token: 0x04007D4F RID: 32079
	public int i_birthday_count;

	// Token: 0x04007D50 RID: 32080
	public int i_trigger_type;

	// Token: 0x04007D51 RID: 32081
	public int bird_round_id;
}
