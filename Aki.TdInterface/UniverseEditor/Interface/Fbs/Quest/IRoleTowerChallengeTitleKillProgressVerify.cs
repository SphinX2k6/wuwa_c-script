using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C3 RID: 16579
	public static class IRoleTowerChallengeTitleKillProgressVerify
	{
		// Token: 0x0601827F RID: 98943 RVA: 0x0037B2F2 File Offset: 0x003794F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
