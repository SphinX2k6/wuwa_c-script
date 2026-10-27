using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C6 RID: 16582
	public static class IRoleTowerChallengeTitlePhantomExpVerify
	{
		// Token: 0x06018291 RID: 98961 RVA: 0x0037B46A File Offset: 0x0037966A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
