using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E9C RID: 32412
	public static class TCommonTipOptionVerify
	{
		// Token: 0x0603A862 RID: 239714 RVA: 0x007E03D8 File Offset: 0x007DE5D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBadBuKingChallengeTipVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBlackCatWarningVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonTipChallengeConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICommonTipChallengeFailVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonTipChallengeSuccessVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICommonTipEnterInRangeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICommonTipFirstCompleteVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICommonTipGeneralFloatingTipVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICommonTipIdVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICommonTipMissionCompleteVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICommonTipMissionCompleteNewVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICommonTipPrepareCountdownVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ICommonTipReachChallengeVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ICommonTipTriggerDelegationVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IDreamlessWarningVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IFlipperTipVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IFrequencyDetectionTipVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IGreatSwordChallengeVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IMoraleAreaTipVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = INightmareLordTipVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = INightmareSpawnPointTipVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IPhotographicTipVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IPunishReportVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IRedNameMonsterTipVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IRemainStarWarningVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IRoleTowerStrongEnemyWarningVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = ISheriffCashSettlementVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = ISheriffCriminalArrestedVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = ISheriffStartTrackVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ISlashAndTowerTipVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ISwordIntentTipVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ITeachAutoShowEndVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ITeachAutoShowStartVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = ITrapDefenseTipVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IVisionSettlementHardTipVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IVisionSettlementTipVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IWhiteCatWarningVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
