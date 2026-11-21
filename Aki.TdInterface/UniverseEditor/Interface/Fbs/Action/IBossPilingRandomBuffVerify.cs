using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688B RID: 26763
	public static class IBossPilingRandomBuffVerify
	{
		// Token: 0x0602DBF6 RID: 187382 RVA: 0x00641056 File Offset: 0x0063F256
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
