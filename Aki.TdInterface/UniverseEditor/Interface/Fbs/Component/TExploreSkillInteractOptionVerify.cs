using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1A RID: 23578
	public static class TExploreSkillInteractOptionVerify
	{
		// Token: 0x06028714 RID: 165652 RVA: 0x00590D2C File Offset: 0x0058EF2C
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
				result = IExploreSkillLonelyDollPollutantVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IExploreSkillMechascoutDragVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IExploreSkillPullGiantVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IExploreSkillPullStatueVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IExploreSkillQuantumDiffusionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IExploreSkillRagDollCrushingRockVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IExploreSkillRagDollDestroySolidRockVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IExploreSkillStatueInteractPointVerify.Verify(verifier, tablePos);
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
