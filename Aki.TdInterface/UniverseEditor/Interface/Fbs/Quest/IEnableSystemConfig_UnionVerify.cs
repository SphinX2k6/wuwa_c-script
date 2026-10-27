using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF6 RID: 15862
	public static class IEnableSystemConfig_UnionVerify
	{
		// Token: 0x060162F0 RID: 90864 RVA: 0x003342FC File Offset: 0x003324FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnableSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGradingSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrapDefenseSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGameDifficultySystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISurvivorsRougeSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IKurotatoSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRoleTowerSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ILinkSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IMotorRacingSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = INightmareSettlementSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IMotorFightSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IFlagChallengeSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IFlipperSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IRogueTowerTrialSystemConfigVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IKuroSimpleCombatKillMonsterSystemConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
