using System;
using System.Runtime.CompilerServices;

// Token: 0x0200216C RID: 8556
[NullableContext(1)]
[Nullable(0)]
public class AreaTerminalOpenActivityLogEvent : PlayerCommonLogData
{
	// Token: 0x1700150E RID: 5390
	// (get) Token: 0x06010A78 RID: 68216 RVA: 0x0040C420 File Offset: 0x0040A620
	// (set) Token: 0x06010A79 RID: 68217 RVA: 0x0040C428 File Offset: 0x0040A628
	public override string event_id { get; set; } = "1923";

	// Token: 0x04007E5B RID: 32347
	public int i_id;

	// Token: 0x04007E5C RID: 32348
	public int i_type;
}
