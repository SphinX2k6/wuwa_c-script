using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007691 RID: 30353
	public static class TCommonTipOptionVerify
	{
		// Token: 0x060373BF RID: 226239 RVA: 0x0077C2D8 File Offset: 0x0077A4D8
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
				result = IGreatSwordChallengeVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IMoraleAreaTipVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = INightmareLordTipVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = INightmareSpawnPointTipVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IPhotographicTipVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IPunishReportVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IRemainStarWarningVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = ISheriffCashSettlementVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = ISheriffCriminalArrestedVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = ISheriffStartTrackVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = ISlashAndTowerTipVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = ISwordIntentTipVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = ITrapDefenseTipVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IVisionSettlementHardTipVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IVisionSettlementTipVerify.Verify(verifier, tablePos);
				break;
			case 32:
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
