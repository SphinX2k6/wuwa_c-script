using System;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200510F RID: 20751
	public enum EAddCardResult
	{
		// Token: 0x0401C436 RID: 115766
		Success,
		// Token: 0x0401C437 RID: 115767
		CoreSlotLocked,
		// Token: 0x0401C438 RID: 115768
		TotalCoreCardCountLimit,
		// Token: 0x0401C439 RID: 115769
		TotalFieldCardCountLimit,
		// Token: 0x0401C43A RID: 115770
		TotalItemCardCountLimit,
		// Token: 0x0401C43B RID: 115771
		CoreCardSlotLimit,
		// Token: 0x0401C43C RID: 115772
		TotalNormalCardCountLimit,
		// Token: 0x0401C43D RID: 115773
		NormalCardSlotLimit,
		// Token: 0x0401C43E RID: 115774
		ElementLimit,
		// Token: 0x0401C43F RID: 115775
		CardMaxLimitByCost3,
		// Token: 0x0401C440 RID: 115776
		CardMaxLimitByCost1,
		// Token: 0x0401C441 RID: 115777
		AddCountZero
	}
}
