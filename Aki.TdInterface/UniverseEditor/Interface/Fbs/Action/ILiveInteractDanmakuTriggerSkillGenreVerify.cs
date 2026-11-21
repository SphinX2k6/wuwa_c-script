using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007105 RID: 28933
	public static class ILiveInteractDanmakuTriggerSkillGenreVerify
	{
		// Token: 0x0603240A RID: 205834 RVA: 0x006CBC68 File Offset: 0x006C9E68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
