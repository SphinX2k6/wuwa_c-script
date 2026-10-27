using System;
using System.Runtime.CompilerServices;

// Token: 0x02002121 RID: 8481
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerAdventureJumpLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C7 RID: 5319
	// (get) Token: 0x0601099F RID: 67999 RVA: 0x0040B884 File Offset: 0x00409A84
	// (set) Token: 0x060109A0 RID: 68000 RVA: 0x0040B88C File Offset: 0x00409A8C
	public override string event_id { get; set; } = "2004";

	// Token: 0x04007D02 RID: 32002
	public int i_roleid_id;

	// Token: 0x04007D03 RID: 32003
	public int i_inst_type;

	// Token: 0x04007D04 RID: 32004
	public int i_inst_id;

	// Token: 0x04007D05 RID: 32005
	public int i_time_left;
}
