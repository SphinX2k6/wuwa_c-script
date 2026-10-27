using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B49 RID: 19273
	public static class ICheckSystemStateType_UnionVerify
	{
		// Token: 0x0601E588 RID: 124296 RVA: 0x00440578 File Offset: 0x0043E778
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckSystemStateTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckMoonBuildingStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckCollectionShopStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICheckTrackMoonPopularityVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICheckInfrastructureStageVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICheckRoadBuildStateVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICheckInfrActivityExpVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICheckVillageInfrLevelVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICheckEncircleLevelCompleteVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICheckSpringFestivalAtmosphereLevelVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICheckSpringFestivalGuessJokerFirstCompleteVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICheckCoopRoleCoopLevelVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ICheckSunSpiritDeliveryLevelVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ICheckRhythmSpaceshipReachLevelRankVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ICheckDropCatchGameplayCompleteLevelVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ICheckDangoBrawlChallengeCompleteVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ICheckRogueStateVerify.Verify(verifier, tablePos);
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
