using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F4 RID: 8436
[NullableContext(1)]
[Nullable(0)]
public class OnOpenGiftPackageDetailsViewLogEvent : PlayerCommonLogData
{
	// Token: 0x1700149A RID: 5274
	// (get) Token: 0x06010918 RID: 67864 RVA: 0x0040B033 File Offset: 0x00409233
	// (set) Token: 0x06010919 RID: 67865 RVA: 0x0040B03B File Offset: 0x0040923B
	public override string event_id { get; set; } = "1828";

	// Token: 0x04007C3D RID: 31805
	public int i_id;

	// Token: 0x04007C3E RID: 31806
	public int i_shop_id;

	// Token: 0x04007C3F RID: 31807
	public int i_tab_id;

	// Token: 0x04007C40 RID: 31808
	public int i_buy_through_third_party;
}
