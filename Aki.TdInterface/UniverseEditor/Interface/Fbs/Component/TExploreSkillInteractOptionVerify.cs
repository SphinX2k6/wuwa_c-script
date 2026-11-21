using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006239 RID: 25145
	public static class TExploreSkillInteractOptionVerify
	{
		// Token: 0x0602AD06 RID: 175366 RVA: 0x005D8CA8 File Offset: 0x005D6EA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExploreSkillArrowInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExploreSkillCustomVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IExploreSkillEavesdropVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IExploreSkillGraffitiPuzzleVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IExploreSkillLonelyDollPollutantVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IExploreSkillMechascoutDragVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IExploreSkillPullGiantVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IExploreSkillPullStatueVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IExploreSkillQuantumDiffusionVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IExploreSkillRagDollCrushingRockVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IExploreSkillRagDollDestroySolidRockVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IExploreSkillStatueInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IFollowShooterInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IFoxJumpInteractPointVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IMonsterSummonInteractPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
