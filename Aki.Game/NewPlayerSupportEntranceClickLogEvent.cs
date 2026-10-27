using System;
using System.Runtime.CompilerServices;

// Token: 0x02002122 RID: 8482
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportEntranceClickLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C8 RID: 5320
	// (get) Token: 0x060109A2 RID: 68002 RVA: 0x0040B8A8 File Offset: 0x00409AA8
	// (set) Token: 0x060109A3 RID: 68003 RVA: 0x0040B8B0 File Offset: 0x00409AB0
	public override string event_id { get; set; } = "2005";

	// Token: 0x04007D07 RID: 32007
	public int i_entrance_id;
}
