using System;
using System.Runtime.CompilerServices;

// Token: 0x020020FC RID: 8444
[NullableContext(1)]
[Nullable(0)]
public class ShareEvent : PlayerCommonLogData
{
	// Token: 0x170014A2 RID: 5282
	// (get) Token: 0x06010930 RID: 67888 RVA: 0x0040B15E File Offset: 0x0040935E
	// (set) Token: 0x06010931 RID: 67889 RVA: 0x0040B166 File Offset: 0x00409366
	public override string event_id { get; set; } = "1053";

	// Token: 0x04007C58 RID: 31832
	public int i_share_channel;

	// Token: 0x04007C59 RID: 31833
	public int i_share_result;

	// Token: 0x04007C5A RID: 31834
	public int i_share_scene;

	// Token: 0x04007C5B RID: 31835
	public int i_extra_choose;
}
