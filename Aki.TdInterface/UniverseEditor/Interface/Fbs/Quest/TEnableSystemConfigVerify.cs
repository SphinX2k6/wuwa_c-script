using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CE RID: 17102
	public static class TEnableSystemConfigVerify
	{
		// Token: 0x060195F0 RID: 103920 RVA: 0x003A3D68 File Offset: 0x003A1F68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFlagChallengeSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFlipperSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGameDifficultySystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGradingSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IKuroSimpleCombatKillMonsterSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IKurotatoSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ILinkSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IMotorFightSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IMotorRacingSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = INightmareSettlementSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IRogueTowerTrialSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IRoleTowerSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ISurvivorsRougeSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ITrapDefenseSystemConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
