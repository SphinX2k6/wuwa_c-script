using System;
using System.Runtime.CompilerServices;

// Token: 0x0200160F RID: 5647
[NullableContext(1)]
[Nullable(0)]
public class BirthdaySelectRoleEvent : PlayerCommonLogData
{
	// Token: 0x1700150B RID: 5387
	// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x00418305 File Offset: 0x00416505
	// (set) Token: 0x0600DE55 RID: 56917 RVA: 0x0041830D File Offset: 0x0041650D
	public override string event_id { get; set; } = "1062";

	// Token: 0x04007E5D RID: 32349
	public int i_role_id;

	// Token: 0x04007E5E RID: 32350
	public bool b_if_selected_role;

	// Token: 0x04007E5F RID: 32351
	public int i_birthday_count;

	// Token: 0x04007E60 RID: 32352
	public int i_trigger_type;

	// Token: 0x04007E61 RID: 32353
	public int bird_round_id;
}
