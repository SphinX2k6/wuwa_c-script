using System;
using System.Runtime.CompilerServices;

// Token: 0x0200216D RID: 8557
[NullableContext(1)]
[Nullable(0)]
public class AreaTerminalActivitySkipLogEvent : PlayerCommonLogData
{
	// Token: 0x1700150F RID: 5391
	// (get) Token: 0x06010A7B RID: 68219 RVA: 0x0040C444 File Offset: 0x0040A644
	// (set) Token: 0x06010A7C RID: 68220 RVA: 0x0040C44C File Offset: 0x0040A64C
	public override string event_id { get; set; } = "1924";

	// Token: 0x04007E5E RID: 32350
	public int i_id;

	// Token: 0x04007E5F RID: 32351
	public int i_type;
}
