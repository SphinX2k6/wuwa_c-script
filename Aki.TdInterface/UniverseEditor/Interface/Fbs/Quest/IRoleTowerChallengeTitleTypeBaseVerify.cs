using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C9 RID: 16585
	public static class IRoleTowerChallengeTitleTypeBaseVerify
	{
		// Token: 0x060182A3 RID: 98979 RVA: 0x0037B5E2 File Offset: 0x003797E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
