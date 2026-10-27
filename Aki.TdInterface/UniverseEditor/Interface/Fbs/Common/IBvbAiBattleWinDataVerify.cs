using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D1E RID: 23838
	public static class IBvbAiBattleWinDataVerify
	{
		// Token: 0x06028BC0 RID: 166848 RVA: 0x0059821E File Offset: 0x0059641E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
