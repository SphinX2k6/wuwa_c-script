using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006386 RID: 25478
	public enum IBvbEventData_Union : byte
	{
		// Token: 0x04010455 RID: 66645
		NONE,
		// Token: 0x04010456 RID: 66646
		IBvbEventData,
		// Token: 0x04010457 RID: 66647
		IBvbAiEvolutionData,
		// Token: 0x04010458 RID: 66648
		IBvbAiDeployData,
		// Token: 0x04010459 RID: 66649
		IBvbAiChangeData,
		// Token: 0x0401045A RID: 66650
		IBvbAiRecycleData,
		// Token: 0x0401045B RID: 66651
		IBvbAiRearrangeData,
		// Token: 0x0401045C RID: 66652
		IBvbAiSwapData,
		// Token: 0x0401045D RID: 66653
		IBvbAiDiscardData,
		// Token: 0x0401045E RID: 66654
		IBvbAiGetBestDeployData,
		// Token: 0x0401045F RID: 66655
		IBvbAiGetBestRearrangeData,
		// Token: 0x04010460 RID: 66656
		IBvbAiGetBestSwapData,
		// Token: 0x04010461 RID: 66657
		IBvbAiGetBestReplaceData,
		// Token: 0x04010462 RID: 66658
		IBvbAiDiscardForEnergyAndActData,
		// Token: 0x04010463 RID: 66659
		IBvbAiTurnEndData,
		// Token: 0x04010464 RID: 66660
		IBvbStartAiData,
		// Token: 0x04010465 RID: 66661
		IBvbStartBattleData,
		// Token: 0x04010466 RID: 66662
		IBvbEnableHatredData,
		// Token: 0x04010467 RID: 66663
		IBvbStartRoundData,
		// Token: 0x04010468 RID: 66664
		IBvbBurnBuffTimeUpData,
		// Token: 0x04010469 RID: 66665
		IBvbWaitForGameBeginData,
		// Token: 0x0401046A RID: 66666
		IBvbPlayerTurnStartData,
		// Token: 0x0401046B RID: 66667
		IBvbPlayerTurnEndData,
		// Token: 0x0401046C RID: 66668
		IBvbAiBattleWinData,
		// Token: 0x0401046D RID: 66669
		IBvbPlayerBattleWinData,
		// Token: 0x0401046E RID: 66670
		IBvbSelectCardsEndData
	}
}
