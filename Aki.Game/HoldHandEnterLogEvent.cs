using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F2 RID: 5618
[NullableContext(1)]
[Nullable(0)]
public class HoldHandEnterLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EE RID: 5358
	// (get) Token: 0x0600DDFD RID: 56829 RVA: 0x00417EAF File Offset: 0x004160AF
	// (set) Token: 0x0600DDFE RID: 56830 RVA: 0x00417EB7 File Offset: 0x004160B7
	public override string event_id { get; set; } = "160301";

	// Token: 0x04007DFF RID: 32255
	public string reason = "";
}
