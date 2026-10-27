using System;
using System.Runtime.CompilerServices;

// Token: 0x0200216A RID: 8554
[NullableContext(1)]
[Nullable(0)]
public class AreaTerminalOpenLogEvent : PlayerCommonLogData
{
	// Token: 0x1700150C RID: 5388
	// (get) Token: 0x06010A72 RID: 68210 RVA: 0x0040C3D8 File Offset: 0x0040A5D8
	// (set) Token: 0x06010A73 RID: 68211 RVA: 0x0040C3E0 File Offset: 0x0040A5E0
	public override string event_id { get; set; } = "1925";

	// Token: 0x04007E58 RID: 32344
	public int i_type;
}
