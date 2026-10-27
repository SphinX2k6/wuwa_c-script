using System;
using System.Runtime.CompilerServices;

// Token: 0x02001779 RID: 6009
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineTabCostItemData
{
	// Token: 0x04004F34 RID: 20276
	public bool IsChosen;

	// Token: 0x04004F35 RID: 20277
	public EVisionRefineCostType CostType;

	// Token: 0x04004F36 RID: 20278
	public string TabTextId;

	// Token: 0x04004F37 RID: 20279
	public Action OnClick;

	// Token: 0x04004F38 RID: 20280
	public Func<EVisionRefineCostType, bool> CanChangeExecute;
}
