using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C3 RID: 5571
[NullableContext(1)]
[Nullable(0)]
public class OnClickGachaScrollLogEvent : PlayerCommonLogData
{
	// Token: 0x170014BF RID: 5311
	// (get) Token: 0x0600DD70 RID: 56688 RVA: 0x00417623 File Offset: 0x00415823
	// (set) Token: 0x0600DD71 RID: 56689 RVA: 0x0041762B File Offset: 0x0041582B
	public override string event_id { get; set; } = "1822";

	// Token: 0x04007D25 RID: 32037
	public int i_gacha_id;
}
