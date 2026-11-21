using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F60 RID: 16224
	public static class TSystemVarVerify
	{
		// Token: 0x06016150 RID: 90448 RVA: 0x0032B4A4 File Offset: 0x003296A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbAdjustPosPreferenceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbCurRoundVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbDungeonStageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbFetchHandCardVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbGetBoardCardVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbGetCardChangeUseVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbGetCardEvolvedUseVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBvbGetCardPosVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IBvbMaxBoardCardCountVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IBvbMaxRoundVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IBvbNpcCardNumVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IBvbNpcCurBoardCardCountVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IBvbNpcCurEnergyVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IBvbNpcHpVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IBvbNpcHpValueVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IBvbNpcScoreVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IBvbPlayerHpVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IBvbPlayerHpValueVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IBvbPlayerScoreVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IBvbRemainEvolveTimeThisTurnVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = ICommonHostToTargetDistanceVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = ICommonHotFixVarVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IQuestBranchPageIdVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IBvbCustomSystemVarIntVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IBvbCustomSystemVarFloatVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
