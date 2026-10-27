using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F3 RID: 8435
[NullableContext(1)]
[Nullable(0)]
public class OnClickRecommendSkinButtonLogEvent : PlayerCommonLogData
{
	// Token: 0x17001499 RID: 5273
	// (get) Token: 0x06010915 RID: 67861 RVA: 0x0040B00F File Offset: 0x0040920F
	// (set) Token: 0x06010916 RID: 67862 RVA: 0x0040B017 File Offset: 0x00409217
	public override string event_id { get; set; } = "1827";

	// Token: 0x04007C3A RID: 31802
	public int i_operation_type;

	// Token: 0x04007C3B RID: 31803
	public int i_item_id;
}
