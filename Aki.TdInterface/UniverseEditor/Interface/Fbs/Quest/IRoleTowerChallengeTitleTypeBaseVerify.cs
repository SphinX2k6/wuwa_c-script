using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200450A RID: 17674
	public static class IRoleTowerChallengeTitleTypeBaseVerify
	{
		// Token: 0x06019944 RID: 104772 RVA: 0x003A5532 File Offset: 0x003A3732
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
