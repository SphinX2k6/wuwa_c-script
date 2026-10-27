using System;
using System.Runtime.CompilerServices;

// Token: 0x020020FF RID: 8447
[NullableContext(1)]
[Nullable(0)]
public class LinkageClickGoEvent : PlayerCommonLogData
{
	// Token: 0x170014A5 RID: 5285
	// (get) Token: 0x06010939 RID: 67897 RVA: 0x0040B1D5 File Offset: 0x004093D5
	// (set) Token: 0x0601093A RID: 67898 RVA: 0x0040B1DD File Offset: 0x004093DD
	public override string event_id { get; set; } = "1059";

	// Token: 0x04007C65 RID: 31845
	public int i_activity_id;

	// Token: 0x04007C66 RID: 31846
	public int i_activity_type;

	// Token: 0x04007C67 RID: 31847
	public int i_id;
}
