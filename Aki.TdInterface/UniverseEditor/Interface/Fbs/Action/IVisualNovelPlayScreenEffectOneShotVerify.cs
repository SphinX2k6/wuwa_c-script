using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DCF RID: 32207
	public static class IVisualNovelPlayScreenEffectOneShotVerify
	{
		// Token: 0x0603A338 RID: 238392 RVA: 0x007D844F File Offset: 0x007D664F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
