using System;
using System.Runtime.CompilerServices;

// Token: 0x02002149 RID: 8521
[NullableContext(1)]
[Nullable(0)]
public class PhonographPlayLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EE RID: 5358
	// (get) Token: 0x06010A15 RID: 68117 RVA: 0x0040BECE File Offset: 0x0040A0CE
	// (set) Token: 0x06010A16 RID: 68118 RVA: 0x0040BED6 File Offset: 0x0040A0D6
	public override string event_id { get; set; } = "101701";

	// Token: 0x04007DA9 RID: 32169
	public int i_item_id;

	// Token: 0x04007DAA RID: 32170
	public int i_album_id;
}
