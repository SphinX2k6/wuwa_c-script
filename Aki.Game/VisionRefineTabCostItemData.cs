using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C32 RID: 3122
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineTabCostItemData
{
	// Token: 0x04004FDE RID: 20446
	public bool IsChosen;

	// Token: 0x04004FDF RID: 20447
	public EVisionRefineCostType CostType;

	// Token: 0x04004FE0 RID: 20448
	public string TabTextId;

	// Token: 0x04004FE1 RID: 20449
	public Action OnClick;

	// Token: 0x04004FE2 RID: 20450
	public Func<EVisionRefineCostType, bool> CanChangeExecute;
}
