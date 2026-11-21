using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A5 RID: 18085
	public static class IUseSkillCheckBase_UnionVerify
	{
		// Token: 0x0601A8FC RID: 108796 RVA: 0x003C7474 File Offset: 0x003C5674
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUseSkillCheckBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUseSkillCheckBySkillGenreVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUseSkillCheckBySkillIdVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IUseSkillCheckByVisionSummonIdVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IUseSkillCheckByVisionShowIdVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IUseSkillCheckByFollowShooterSkillIdVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
