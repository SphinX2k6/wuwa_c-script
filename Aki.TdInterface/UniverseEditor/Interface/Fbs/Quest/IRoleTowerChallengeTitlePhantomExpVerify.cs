using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004507 RID: 17671
	public static class IRoleTowerChallengeTitlePhantomExpVerify
	{
		// Token: 0x06019932 RID: 104754 RVA: 0x003A53BA File Offset: 0x003A35BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
