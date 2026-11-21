using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED7 RID: 16087
	public enum ISystemVarBase_Union : byte
	{
		// Token: 0x0400B8E5 RID: 47333
		NONE,
		// Token: 0x0400B8E6 RID: 47334
		ISystemVarBase,
		// Token: 0x0400B8E7 RID: 47335
		IBvbFetchHandCard,
		// Token: 0x0400B8E8 RID: 47336
		IBvbGetBoardCard,
		// Token: 0x0400B8E9 RID: 47337
		IBvbGetCardPos,
		// Token: 0x0400B8EA RID: 47338
		IBvbGetCardChangeUse,
		// Token: 0x0400B8EB RID: 47339
		IBvbGetCardEvolvedUse,
		// Token: 0x0400B8EC RID: 47340
		IBvbAdjustPosPreference,
		// Token: 0x0400B8ED RID: 47341
		IBvbCurRound,
		// Token: 0x0400B8EE RID: 47342
		IBvbRemainEvolveTimeThisTurn,
		// Token: 0x0400B8EF RID: 47343
		IBvbMaxRound,
		// Token: 0x0400B8F0 RID: 47344
		IBvbNpcCardNum,
		// Token: 0x0400B8F1 RID: 47345
		IBvbNpcCurEnergy,
		// Token: 0x0400B8F2 RID: 47346
		IBvbNpcScore,
		// Token: 0x0400B8F3 RID: 47347
		IBvbPlayerScore,
		// Token: 0x0400B8F4 RID: 47348
		IBvbPlayerHp,
		// Token: 0x0400B8F5 RID: 47349
		IBvbNpcHp,
		// Token: 0x0400B8F6 RID: 47350
		IBvbPlayerHpValue,
		// Token: 0x0400B8F7 RID: 47351
		IBvbNpcHpValue,
		// Token: 0x0400B8F8 RID: 47352
		IBvbNpcCurBoardCardCount,
		// Token: 0x0400B8F9 RID: 47353
		IBvbMaxBoardCardCount,
		// Token: 0x0400B8FA RID: 47354
		IBvbDungeonStage,
		// Token: 0x0400B8FB RID: 47355
		IBvbCustomSystemVarInt,
		// Token: 0x0400B8FC RID: 47356
		IBvbCustomSystemVarFloat,
		// Token: 0x0400B8FD RID: 47357
		IQuestBranchPageId,
		// Token: 0x0400B8FE RID: 47358
		ICommonHotFixVar,
		// Token: 0x0400B8FF RID: 47359
		ICommonHostToTargetDistance
	}
}
