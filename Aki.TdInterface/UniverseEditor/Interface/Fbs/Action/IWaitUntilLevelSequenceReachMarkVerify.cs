using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E11 RID: 32273
	public static class IWaitUntilLevelSequenceReachMarkVerify
	{
		// Token: 0x0603A52E RID: 238894 RVA: 0x007DB6EB File Offset: 0x007D98EB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
