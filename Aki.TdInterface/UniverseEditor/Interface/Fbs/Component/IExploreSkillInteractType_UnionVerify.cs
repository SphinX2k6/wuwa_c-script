using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005759 RID: 22361
	public static class IExploreSkillInteractType_UnionVerify
	{
		// Token: 0x060240B3 RID: 147635 RVA: 0x004F5248 File Offset: 0x004F3448
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExploreSkillInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExploreSkillPullGiantVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IExploreSkillStatueInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IExploreSkillPullStatueVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IExploreSkillRagDollCrushingRockVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IExploreSkillRagDollDestroySolidRockVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IExploreSkillLonelyDollPollutantVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IExploreSkillQuantumDiffusionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IExploreSkillCustomVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IExploreSkillMechascoutDragVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IExploreSkillArrowInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IFollowShooterInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IFoxJumpInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IMonsterSummonInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IExploreSkillEavesdropVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IExploreSkillGraffitiPuzzleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
