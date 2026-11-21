using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F3 RID: 5619
[NullableContext(1)]
[Nullable(0)]
public class HoldHandExitLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EF RID: 5359
	// (get) Token: 0x0600DE00 RID: 56832 RVA: 0x00417EDE File Offset: 0x004160DE
	// (set) Token: 0x0600DE01 RID: 56833 RVA: 0x00417EE6 File Offset: 0x004160E6
	public override string event_id { get; set; } = "160302";

	// Token: 0x04007E01 RID: 32257
	public string reason = "";
}
