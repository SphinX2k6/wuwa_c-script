using System;
using System.Runtime.CompilerServices;

// Token: 0x02001613 RID: 5651
[NullableContext(1)]
[Nullable(0)]
public class SubPackageOutOfSpaceLogEvent : CommonLogData
{
	// Token: 0x1700150F RID: 5391
	// (get) Token: 0x0600DE60 RID: 56928 RVA: 0x004183AB File Offset: 0x004165AB
	// (set) Token: 0x0600DE61 RID: 56929 RVA: 0x004183B3 File Offset: 0x004165B3
	public override string event_id { get; set; } = "1707";

	// Token: 0x04007E75 RID: 32373
	public string s_suit_name = "";

	// Token: 0x04007E76 RID: 32374
	public int i_resource_type;

	// Token: 0x04007E77 RID: 32375
	public bool b_if_storage_alert;

	// Token: 0x04007E78 RID: 32376
	public int i_required_space;

	// Token: 0x04007E79 RID: 32377
	public int i_remaining_space;

	// Token: 0x04007E7A RID: 32378
	public int i_role_id;
}
