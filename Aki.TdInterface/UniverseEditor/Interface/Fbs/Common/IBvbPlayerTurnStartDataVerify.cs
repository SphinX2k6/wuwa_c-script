using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D5A RID: 23898
	public static class IBvbPlayerTurnStartDataVerify
	{
		// Token: 0x06028E31 RID: 167473 RVA: 0x0059E32A File Offset: 0x0059C52A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
