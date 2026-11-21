using System;
using System.Runtime.CompilerServices;

// Token: 0x02001644 RID: 5700
[NullableContext(1)]
[Nullable(0)]
public class AreaTerminalOpenActivityLogEvent : PlayerCommonLogData
{
	// Token: 0x1700153C RID: 5436
	// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x00418B68 File Offset: 0x00416D68
	// (set) Token: 0x0600DEEC RID: 57068 RVA: 0x00418B70 File Offset: 0x00416D70
	public override string event_id { get; set; } = "1923";

	// Token: 0x04007F6B RID: 32619
	public int i_id;

	// Token: 0x04007F6C RID: 32620
	public int i_type;
}
