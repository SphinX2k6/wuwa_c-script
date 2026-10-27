using System;
using System.Runtime.CompilerServices;

// Token: 0x0200211A RID: 8474
[NullableContext(1)]
[Nullable(0)]
public class HoldHandEnterLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C0 RID: 5312
	// (get) Token: 0x0601098A RID: 67978 RVA: 0x0040B767 File Offset: 0x00409967
	// (set) Token: 0x0601098B RID: 67979 RVA: 0x0040B76F File Offset: 0x0040996F
	public override string event_id { get; set; } = "160301";

	// Token: 0x04007CF1 RID: 31985
	public string reason = "";
}
