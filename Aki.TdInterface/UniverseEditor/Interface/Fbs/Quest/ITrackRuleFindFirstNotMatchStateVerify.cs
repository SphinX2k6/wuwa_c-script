using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004210 RID: 16912
	public static class ITrackRuleFindFirstNotMatchStateVerify
	{
		// Token: 0x06018FE0 RID: 102368 RVA: 0x00398D33 File Offset: 0x00396F33
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
