using System;
using System.Runtime.CompilerServices;

// Token: 0x020015EB RID: 5611
[NullableContext(1)]
[Nullable(0)]
public class NewTowerRewardPreviewEvent : PlayerCommonLogData
{
	// Token: 0x170014E7 RID: 5351
	// (get) Token: 0x0600DDE8 RID: 56808 RVA: 0x00417C30 File Offset: 0x00415E30
	// (set) Token: 0x0600DDE9 RID: 56809 RVA: 0x00417C38 File Offset: 0x00415E38
	public override string event_id { get; set; } = "1073";

	// Token: 0x04007DA5 RID: 32165
	public int i_goods_id;

	// Token: 0x04007DA6 RID: 32166
	public int i_item_id;

	// Token: 0x04007DA7 RID: 32167
	public int i_skin_id;
}
