using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004331 RID: 17201
	public static class TUseSkillCheckVerify
	{
		// Token: 0x06019820 RID: 104480 RVA: 0x003A7460 File Offset: 0x003A5660
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
