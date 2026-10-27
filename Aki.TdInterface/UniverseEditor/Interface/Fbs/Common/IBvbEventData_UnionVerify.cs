using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D51 RID: 23889
	public static class IBvbEventData_UnionVerify
	{
		// Token: 0x06028DFB RID: 167419 RVA: 0x0059DD44 File Offset: 0x0059BF44
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbEventDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbAiEvolutionDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbAiDeployDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbAiChangeDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbAiRecycleDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbAiRearrangeDataVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbAiSwapDataVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBvbAiDiscardDataVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IBvbAiGetBestDeployDataVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IBvbAiGetBestRearrangeDataVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IBvbAiGetBestSwapDataVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IBvbAiGetBestReplaceDataVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IBvbAiDiscardForEnergyAndActDataVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IBvbAiTurnEndDataVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IBvbStartAiDataVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IBvbStartBattleDataVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IBvbEnableHatredDataVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IBvbStartRoundDataVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IBvbBurnBuffTimeUpDataVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IBvbWaitForGameBeginDataVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IBvbPlayerTurnStartDataVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IBvbPlayerTurnEndDataVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IBvbAiBattleWinDataVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IBvbPlayerBattleWinDataVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IBvbSelectCardsEndDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
