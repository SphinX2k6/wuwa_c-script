using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D4F RID: 23887
	public enum IBvbEventData_Union : byte
	{
		// Token: 0x0400F703 RID: 63235
		NONE,
		// Token: 0x0400F704 RID: 63236
		IBvbEventData,
		// Token: 0x0400F705 RID: 63237
		IBvbAiEvolutionData,
		// Token: 0x0400F706 RID: 63238
		IBvbAiDeployData,
		// Token: 0x0400F707 RID: 63239
		IBvbAiChangeData,
		// Token: 0x0400F708 RID: 63240
		IBvbAiRecycleData,
		// Token: 0x0400F709 RID: 63241
		IBvbAiRearrangeData,
		// Token: 0x0400F70A RID: 63242
		IBvbAiSwapData,
		// Token: 0x0400F70B RID: 63243
		IBvbAiDiscardData,
		// Token: 0x0400F70C RID: 63244
		IBvbAiGetBestDeployData,
		// Token: 0x0400F70D RID: 63245
		IBvbAiGetBestRearrangeData,
		// Token: 0x0400F70E RID: 63246
		IBvbAiGetBestSwapData,
		// Token: 0x0400F70F RID: 63247
		IBvbAiGetBestReplaceData,
		// Token: 0x0400F710 RID: 63248
		IBvbAiDiscardForEnergyAndActData,
		// Token: 0x0400F711 RID: 63249
		IBvbAiTurnEndData,
		// Token: 0x0400F712 RID: 63250
		IBvbStartAiData,
		// Token: 0x0400F713 RID: 63251
		IBvbStartBattleData,
		// Token: 0x0400F714 RID: 63252
		IBvbEnableHatredData,
		// Token: 0x0400F715 RID: 63253
		IBvbStartRoundData,
		// Token: 0x0400F716 RID: 63254
		IBvbBurnBuffTimeUpData,
		// Token: 0x0400F717 RID: 63255
		IBvbWaitForGameBeginData,
		// Token: 0x0400F718 RID: 63256
		IBvbPlayerTurnStartData,
		// Token: 0x0400F719 RID: 63257
		IBvbPlayerTurnEndData,
		// Token: 0x0400F71A RID: 63258
		IBvbAiBattleWinData,
		// Token: 0x0400F71B RID: 63259
		IBvbPlayerBattleWinData,
		// Token: 0x0400F71C RID: 63260
		IBvbSelectCardsEndData
	}
}
