using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F26 RID: 32550
	public static class TLiveInteractDanmakuTriggerVerify
	{
		// Token: 0x0603AB7E RID: 240510 RVA: 0x007E576C File Offset: 0x007E396C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveInteractDanmakuTriggerBattleEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveInteractDanmakuTriggerSkillGenreVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveInteractDanmakuTriggerSkillIdVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
