using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007650 RID: 30288
	public enum TBvbPlayerOperationType : byte
	{
		// Token: 0x04012603 RID: 75267
		NONE,
		// Token: 0x04012604 RID: 75268
		IBvbChangeBoardCard,
		// Token: 0x04012605 RID: 75269
		IBvbChangeHandCard,
		// Token: 0x04012606 RID: 75270
		IBvbDeploy,
		// Token: 0x04012607 RID: 75271
		IBvbEndTurn,
		// Token: 0x04012608 RID: 75272
		IBvbEvolution,
		// Token: 0x04012609 RID: 75273
		IBvbRecycleBoardCard,
		// Token: 0x0401260A RID: 75274
		IBvbRecycleHandCard,
		// Token: 0x0401260B RID: 75275
		IBvbSelectCard,
		// Token: 0x0401260C RID: 75276
		IBvbUseFieldCardSkill,
		// Token: 0x0401260D RID: 75277
		IBvbUseItemCardSkill
	}
}
