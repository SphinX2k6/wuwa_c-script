using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006265 RID: 25189
	public static class IBvbSkipChallengeVerify
	{
		// Token: 0x0602B765 RID: 178021 RVA: 0x005FBDC6 File Offset: 0x005F9FC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
