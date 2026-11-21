using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D6 RID: 26838
	public static class IBvbSkipChallengeVerify
	{
		// Token: 0x0602DEC6 RID: 188102 RVA: 0x00646BCE File Offset: 0x00644DCE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
