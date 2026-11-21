using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B20 RID: 27424
	public static class ICommonTipType_UnionVerify
	{
		// Token: 0x0602F2BD RID: 193213 RVA: 0x0066E430 File Offset: 0x0066C630
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonTipTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonTipChallengeConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonTipChallengeSuccessVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICommonTipChallengeFailVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonTipReachChallengeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICommonTipTriggerDelegationVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICommonTipMissionCompleteVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICommonTipMissionCompleteNewVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICommonTipGeneralFloatingTipVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICommonTipIdVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICommonTipPrepareCountdownVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICommonTipEnterInRangeVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ICommonTipFirstCompleteVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IRemainStarWarningVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ISlashAndTowerTipVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IDreamlessWarningVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IBlackCatWarningVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IWhiteCatWarningVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IBadBuKingChallengeTipVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IPunishReportVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IMoraleAreaTipVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = INightmareLordTipVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = INightmareSpawnPointTipVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IGreatSwordChallengeVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = ITrapDefenseTipVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IPhotographicTipVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IVisionSettlementTipVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IVisionSettlementHardTipVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IFlipperTipVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ISheriffStartTrackVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ISheriffCriminalArrestedVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ISheriffCashSettlementVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ISwordIntentTipVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IRedNameMonsterTipVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IRoleTowerStrongEnemyWarningVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = ITeachAutoShowStartVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = ITeachAutoShowEndVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IFrequencyDetectionTipVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
