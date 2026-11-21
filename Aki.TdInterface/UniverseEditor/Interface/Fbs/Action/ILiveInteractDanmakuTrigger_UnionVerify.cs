using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710B RID: 28939
	public static class ILiveInteractDanmakuTrigger_UnionVerify
	{
		// Token: 0x06032430 RID: 205872 RVA: 0x006CBFD0 File Offset: 0x006CA1D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveInteractDanmakuTriggerVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveInteractDanmakuTriggerSkillGenreVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveInteractDanmakuTriggerSkillIdVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveInteractDanmakuTriggerBattleEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
