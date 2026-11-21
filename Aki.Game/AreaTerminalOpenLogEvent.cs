using System;
using System.Runtime.CompilerServices;

// Token: 0x02001642 RID: 5698
[NullableContext(1)]
[Nullable(0)]
public class AreaTerminalOpenLogEvent : PlayerCommonLogData
{
	// Token: 0x1700153A RID: 5434
	// (get) Token: 0x0600DEE5 RID: 57061 RVA: 0x00418B20 File Offset: 0x00416D20
	// (set) Token: 0x0600DEE6 RID: 57062 RVA: 0x00418B28 File Offset: 0x00416D28
	public override string event_id { get; set; } = "1925";

	// Token: 0x04007F68 RID: 32616
	public int i_type;
}
