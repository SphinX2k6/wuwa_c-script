using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005237 RID: 21047
	public static class TCheckSystemStateVerify
	{
		// Token: 0x06021274 RID: 135796 RVA: 0x00493C1C File Offset: 0x00491E1C
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
				result = ICheckHandBookPageCompleteVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICheckInfrActivityExpVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICheckInfrastructureStageVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICheckMoonBuildingStateVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICheckRhythmSpaceshipReachLevelRankVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICheckRoadBuildStateVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICheckRogueStateVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ICheckSpringFestivalAtmosphereLevelVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ICheckSpringFestivalGuessJokerFirstCompleteVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ICheckSunSpiritDeliveryLevelVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ICheckTrackMoonPopularityVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ICheckVillageInfrLevelVerify.Verify(verifier, tablePos);
				break;
			case 18:
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
