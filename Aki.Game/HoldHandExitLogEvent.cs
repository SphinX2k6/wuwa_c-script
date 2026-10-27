using System;
using System.Runtime.CompilerServices;

// Token: 0x0200211B RID: 8475
[NullableContext(1)]
[Nullable(0)]
public class HoldHandExitLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C1 RID: 5313
	// (get) Token: 0x0601098D RID: 67981 RVA: 0x0040B796 File Offset: 0x00409996
	// (set) Token: 0x0601098E RID: 67982 RVA: 0x0040B79E File Offset: 0x0040999E
	public override string event_id { get; set; } = "160302";

	// Token: 0x04007CF3 RID: 31987
	public string reason = "";
}
