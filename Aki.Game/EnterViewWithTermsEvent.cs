using System;
using System.Runtime.CompilerServices;

// Token: 0x0200210D RID: 8461
[NullableContext(1)]
[Nullable(0)]
public class EnterViewWithTermsEvent : PlayerCommonLogData
{
	// Token: 0x170014B3 RID: 5299
	// (get) Token: 0x06010963 RID: 67939 RVA: 0x0040B419 File Offset: 0x00409619
	// (set) Token: 0x06010964 RID: 67940 RVA: 0x0040B421 File Offset: 0x00409621
	public override string event_id { get; set; } = "1067";

	// Token: 0x04007C91 RID: 31889
	public int i_scene;
}
