using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC6 RID: 32198
	public static class IVisualNovelPlayScreenEffectConfigBaseVerify
	{
		// Token: 0x0603A2FA RID: 238330 RVA: 0x007D7E9A File Offset: 0x007D609A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
