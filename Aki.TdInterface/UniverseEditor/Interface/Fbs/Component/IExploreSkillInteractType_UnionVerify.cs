using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F1 RID: 20977
	public static class IExploreSkillInteractType_UnionVerify
	{
		// Token: 0x0602211D RID: 139549 RVA: 0x004BA794 File Offset: 0x004B8994
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
