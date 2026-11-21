using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD2 RID: 32210
	public static class IVisualNovelPlayScreenEffectPersistentVerify
	{
		// Token: 0x0603A350 RID: 238416 RVA: 0x007D8683 File Offset: 0x007D6883
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
