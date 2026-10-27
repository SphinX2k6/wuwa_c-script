using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD5 RID: 15061
	public enum ISystemVarBase_Union : byte
	{
		// Token: 0x0400AF78 RID: 44920
		NONE,
		// Token: 0x0400AF79 RID: 44921
		ISystemVarBase,
		// Token: 0x0400AF7A RID: 44922
		IBvbFetchHandCard,
		// Token: 0x0400AF7B RID: 44923
		IBvbGetBoardCard,
		// Token: 0x0400AF7C RID: 44924
		IBvbGetCardPos,
		// Token: 0x0400AF7D RID: 44925
		IBvbGetCardChangeUse,
		// Token: 0x0400AF7E RID: 44926
		IBvbGetCardEvolvedUse,
		// Token: 0x0400AF7F RID: 44927
		IBvbAdjustPosPreference,
		// Token: 0x0400AF80 RID: 44928
		IBvbCurRound,
		// Token: 0x0400AF81 RID: 44929
		IBvbRemainEvolveTimeThisTurn,
		// Token: 0x0400AF82 RID: 44930
		IBvbMaxRound,
		// Token: 0x0400AF83 RID: 44931
		IBvbNpcCardNum,
		// Token: 0x0400AF84 RID: 44932
		IBvbNpcCurEnergy,
		// Token: 0x0400AF85 RID: 44933
		IBvbNpcScore,
		// Token: 0x0400AF86 RID: 44934
		IBvbPlayerScore,
		// Token: 0x0400AF87 RID: 44935
		IBvbPlayerHp,
		// Token: 0x0400AF88 RID: 44936
		IBvbNpcHp,
		// Token: 0x0400AF89 RID: 44937
		IBvbPlayerHpValue,
		// Token: 0x0400AF8A RID: 44938
		IBvbNpcHpValue,
		// Token: 0x0400AF8B RID: 44939
		IBvbNpcCurBoardCardCount,
		// Token: 0x0400AF8C RID: 44940
		IBvbMaxBoardCardCount,
		// Token: 0x0400AF8D RID: 44941
		IBvbDungeonStage,
		// Token: 0x0400AF8E RID: 44942
		IBvbCustomSystemVarInt,
		// Token: 0x0400AF8F RID: 44943
		IBvbCustomSystemVarFloat,
		// Token: 0x0400AF90 RID: 44944
		IQuestBranchPageId,
		// Token: 0x0400AF91 RID: 44945
		ICommonHotFixVar,
		// Token: 0x0400AF92 RID: 44946
		ICommonHostToTargetDistance
	}
}
