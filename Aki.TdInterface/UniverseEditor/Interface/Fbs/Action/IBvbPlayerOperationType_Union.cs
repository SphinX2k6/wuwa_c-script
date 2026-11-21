using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C2 RID: 26818
	public enum IBvbPlayerOperationType_Union : byte
	{
		// Token: 0x040115B4 RID: 71092
		NONE,
		// Token: 0x040115B5 RID: 71093
		IBvbPlayerOperationType,
		// Token: 0x040115B6 RID: 71094
		IBvbDeploy,
		// Token: 0x040115B7 RID: 71095
		IBvbEvolution,
		// Token: 0x040115B8 RID: 71096
		IBvbChangeHandCard,
		// Token: 0x040115B9 RID: 71097
		IBvbChangeBoardCard,
		// Token: 0x040115BA RID: 71098
		IBvbRecycleHandCard,
		// Token: 0x040115BB RID: 71099
		IBvbRecycleBoardCard,
		// Token: 0x040115BC RID: 71100
		IBvbUseItemCardSkill,
		// Token: 0x040115BD RID: 71101
		IBvbSelectCard,
		// Token: 0x040115BE RID: 71102
		IBvbUseFieldCardSkill,
		// Token: 0x040115BF RID: 71103
		IBvbEndTurn
	}
}
