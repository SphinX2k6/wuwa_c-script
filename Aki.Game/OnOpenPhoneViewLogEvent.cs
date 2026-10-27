using System;
using System.Runtime.CompilerServices;

// Token: 0x02002144 RID: 8516
[NullableContext(1)]
[Nullable(0)]
public class OnOpenPhoneViewLogEvent : PlayerCommonLogData
{
	// Token: 0x170014E9 RID: 5353
	// (get) Token: 0x06010A06 RID: 68102 RVA: 0x0040BE0F File Offset: 0x0040A00F
	// (set) Token: 0x06010A07 RID: 68103 RVA: 0x0040BE17 File Offset: 0x0040A017
	public override string event_id { get; set; } = "1815";

	// Token: 0x04007D90 RID: 32144
	public int i_open_way;

	// Token: 0x04007D91 RID: 32145
	public int i_reason;
}
