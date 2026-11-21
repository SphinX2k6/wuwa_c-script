using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004504 RID: 17668
	public static class IRoleTowerChallengeTitleKillProgressVerify
	{
		// Token: 0x06019920 RID: 104736 RVA: 0x003A5242 File Offset: 0x003A3442
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
