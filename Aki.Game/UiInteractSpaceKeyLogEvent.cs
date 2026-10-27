using System;
using System.Runtime.CompilerServices;

// Token: 0x02002126 RID: 8486
[NullableContext(1)]
[Nullable(0)]
public class UiInteractSpaceKeyLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CC RID: 5324
	// (get) Token: 0x060109AE RID: 68014 RVA: 0x0040B938 File Offset: 0x00409B38
	// (set) Token: 0x060109AF RID: 68015 RVA: 0x0040B940 File Offset: 0x00409B40
	public override string event_id { get; set; } = "1806";

	// Token: 0x04007D0F RID: 32015
	public int i_type;

	// Token: 0x04007D10 RID: 32016
	public int i_status;
}
