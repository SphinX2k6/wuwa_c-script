using System;
using System.Runtime.CompilerServices;

// Token: 0x020015CA RID: 5578
[NullableContext(1)]
[Nullable(0)]
public class OnClickRecommendSkinButtonLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C6 RID: 5318
	// (get) Token: 0x0600DD85 RID: 56709 RVA: 0x0041771F File Offset: 0x0041591F
	// (set) Token: 0x0600DD86 RID: 56710 RVA: 0x00417727 File Offset: 0x00415927
	public override string event_id { get; set; } = "1827";

	// Token: 0x04007D39 RID: 32057
	public int i_operation_type;

	// Token: 0x04007D3A RID: 32058
	public int i_item_id;
}
