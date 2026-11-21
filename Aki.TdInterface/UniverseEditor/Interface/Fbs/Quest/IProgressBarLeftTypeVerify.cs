using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043FF RID: 17407
	public static class IProgressBarLeftTypeVerify
	{
		// Token: 0x06018BE8 RID: 101352 RVA: 0x00386BFA File Offset: 0x00384DFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
