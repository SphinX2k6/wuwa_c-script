using System;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040DF RID: 16607
	public enum EAddCardResult
	{
		// Token: 0x04016E6B RID: 93803
		Success,
		// Token: 0x04016E6C RID: 93804
		CoreSlotLocked,
		// Token: 0x04016E6D RID: 93805
		TotalCoreCardCountLimit,
		// Token: 0x04016E6E RID: 93806
		TotalFieldCardCountLimit,
		// Token: 0x04016E6F RID: 93807
		TotalItemCardCountLimit,
		// Token: 0x04016E70 RID: 93808
		CoreCardSlotLimit,
		// Token: 0x04016E71 RID: 93809
		TotalNormalCardCountLimit,
		// Token: 0x04016E72 RID: 93810
		NormalCardSlotLimit,
		// Token: 0x04016E73 RID: 93811
		ElementLimit,
		// Token: 0x04016E74 RID: 93812
		CardMaxLimitByCost3,
		// Token: 0x04016E75 RID: 93813
		CardMaxLimitByCost1,
		// Token: 0x04016E76 RID: 93814
		AddCountZero
	}
}
