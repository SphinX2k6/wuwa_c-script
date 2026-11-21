using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DED RID: 32237
	public static class IVisualNovelStopScreenEffectPersistentVerify
	{
		// Token: 0x0603A422 RID: 238626 RVA: 0x007D9AEB File Offset: 0x007D7CEB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
