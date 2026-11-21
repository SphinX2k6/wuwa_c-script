using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C7 RID: 5575
[NullableContext(1)]
[Nullable(0)]
public class OnClickFunctionItemLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C3 RID: 5315
	// (get) Token: 0x0600DD7C RID: 56700 RVA: 0x004176B3 File Offset: 0x004158B3
	// (set) Token: 0x0600DD7D RID: 56701 RVA: 0x004176BB File Offset: 0x004158BB
	public override string event_id { get; set; } = "1854";

	// Token: 0x04007D2F RID: 32047
	public int i_id;

	// Token: 0x04007D30 RID: 32048
	public int i_type;
}
