using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D3B RID: 19771
	public static class TCheckSystemStateVerify
	{
		// Token: 0x0601F62B RID: 128555 RVA: 0x0045FC58 File Offset: 0x0045DE58
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckCollectionShopStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckCoopRoleCoopLevelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckDangoBrawlChallengeCompleteVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICheckDropCatchGameplayCompleteLevelVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICheckEncircleLevelCompleteVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICheckInfrActivityExpVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICheckInfrastructureStageVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICheckMoonBuildingStateVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICheckRhythmSpaceshipReachLevelRankVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICheckRoadBuildStateVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICheckRogueStateVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICheckSpringFestivalAtmosphereLevelVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ICheckSpringFestivalGuessJokerFirstCompleteVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ICheckSunSpiritDeliveryLevelVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ICheckTrackMoonPopularityVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ICheckVillageInfrLevelVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ICheckVillageInfrTreeBuildStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
