using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007464 RID: 29796
	public static class IPlayerAiControlBaseVerify
	{
		// Token: 0x060342A0 RID: 213664 RVA: 0x007072AE File Offset: 0x007054AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
