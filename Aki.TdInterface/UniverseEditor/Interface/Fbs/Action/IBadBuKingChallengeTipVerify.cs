using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061DE RID: 25054
	public static class IBadBuKingChallengeTipVerify
	{
		// Token: 0x0602B2F2 RID: 176882 RVA: 0x005F3B9B File Offset: 0x005F1D9B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
