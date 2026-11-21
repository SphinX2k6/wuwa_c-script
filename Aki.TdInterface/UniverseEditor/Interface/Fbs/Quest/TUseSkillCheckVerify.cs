using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004793 RID: 18323
	public static class TUseSkillCheckVerify
	{
		// Token: 0x0601AFAE RID: 110510 RVA: 0x003D2E88 File Offset: 0x003D1088
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUseSkillCheckByFollowShooterSkillIdVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUseSkillCheckBySkillGenreVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUseSkillCheckBySkillIdVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IUseSkillCheckByVisionShowIdVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IUseSkillCheckByVisionSummonIdVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
