using System;
using System.Runtime.CompilerServices;

// Token: 0x02001645 RID: 5701
[NullableContext(1)]
[Nullable(0)]
public class AreaTerminalActivitySkipLogEvent : PlayerCommonLogData
{
	// Token: 0x1700153D RID: 5437
	// (get) Token: 0x0600DEEE RID: 57070 RVA: 0x00418B8C File Offset: 0x00416D8C
	// (set) Token: 0x0600DEEF RID: 57071 RVA: 0x00418B94 File Offset: 0x00416D94
	public override string event_id { get; set; } = "1924";

	// Token: 0x04007F6E RID: 32622
	public int i_id;

	// Token: 0x04007F6F RID: 32623
	public int i_type;
}
