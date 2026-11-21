using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064AE RID: 25774
	public static class TBvbEventDataVerify
	{
		// Token: 0x0602BD2A RID: 179498 RVA: 0x005F5B18 File Offset: 0x005F3D18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbAiBattleWinDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbAiChangeDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbAiDeployDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbAiDiscardDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbAiDiscardForEnergyAndActDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbAiEvolutionDataVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbAiGetBestDeployDataVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBvbAiGetBestRearrangeDataVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IBvbAiGetBestReplaceDataVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IBvbAiGetBestSwapDataVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IBvbAiRearrangeDataVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IBvbAiRecycleDataVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IBvbAiSwapDataVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IBvbAiTurnEndDataVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IBvbBurnBuffTimeUpDataVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IBvbEnableHatredDataVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IBvbPlayerBattleWinDataVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IBvbPlayerTurnEndDataVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IBvbPlayerTurnStartDataVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IBvbSelectCardsEndDataVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IBvbStartAiDataVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IBvbStartBattleDataVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IBvbStartRoundDataVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IBvbWaitForGameBeginDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
