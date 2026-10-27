using System;
using System.Runtime.CompilerServices;

// Token: 0x02002113 RID: 8467
[NullableContext(1)]
[Nullable(0)]
public class NewTowerRewardPreviewEvent : PlayerCommonLogData
{
	// Token: 0x170014B9 RID: 5305
	// (get) Token: 0x06010975 RID: 67957 RVA: 0x0040B4FC File Offset: 0x004096FC
	// (set) Token: 0x06010976 RID: 67958 RVA: 0x0040B504 File Offset: 0x00409704
	public override string event_id { get; set; } = "1073";

	// Token: 0x04007CA3 RID: 31907
	public int i_goods_id;

	// Token: 0x04007CA4 RID: 31908
	public int i_item_id;

	// Token: 0x04007CA5 RID: 31909
	public int i_skin_id;
}
