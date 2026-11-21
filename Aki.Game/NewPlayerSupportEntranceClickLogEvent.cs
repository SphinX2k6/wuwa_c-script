using System;
using System.Runtime.CompilerServices;

// Token: 0x020015FA RID: 5626
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportEntranceClickLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F6 RID: 5366
	// (get) Token: 0x0600DE15 RID: 56853 RVA: 0x00417FF0 File Offset: 0x004161F0
	// (set) Token: 0x0600DE16 RID: 56854 RVA: 0x00417FF8 File Offset: 0x004161F8
	public override string event_id { get; set; } = "2005";

	// Token: 0x04007E15 RID: 32277
	public int i_entrance_id;
}
