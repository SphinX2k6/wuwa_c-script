using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D7 RID: 5591
[NullableContext(1)]
[Nullable(0)]
public class LinkageClickGoEvent : PlayerCommonLogData
{
	// Token: 0x170014D3 RID: 5331
	// (get) Token: 0x0600DDAC RID: 56748 RVA: 0x00417909 File Offset: 0x00415B09
	// (set) Token: 0x0600DDAD RID: 56749 RVA: 0x00417911 File Offset: 0x00415B11
	public override string event_id { get; set; } = "1059";

	// Token: 0x04007D67 RID: 32103
	public int i_activity_id;

	// Token: 0x04007D68 RID: 32104
	public int i_activity_type;

	// Token: 0x04007D69 RID: 32105
	public int i_id;
}
