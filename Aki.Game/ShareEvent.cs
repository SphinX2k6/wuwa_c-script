using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D4 RID: 5588
[NullableContext(1)]
[Nullable(0)]
public class ShareEvent : PlayerCommonLogData
{
	// Token: 0x170014D0 RID: 5328
	// (get) Token: 0x0600DDA3 RID: 56739 RVA: 0x00417892 File Offset: 0x00415A92
	// (set) Token: 0x0600DDA4 RID: 56740 RVA: 0x0041789A File Offset: 0x00415A9A
	public override string event_id { get; set; } = "1053";

	// Token: 0x04007D5A RID: 32090
	public int i_share_channel;

	// Token: 0x04007D5B RID: 32091
	public int i_share_result;

	// Token: 0x04007D5C RID: 32092
	public int i_share_scene;

	// Token: 0x04007D5D RID: 32093
	public int i_extra_choose;
}
