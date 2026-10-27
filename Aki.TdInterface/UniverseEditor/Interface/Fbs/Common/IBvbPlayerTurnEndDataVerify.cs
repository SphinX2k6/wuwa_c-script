using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D57 RID: 23895
	public static class IBvbPlayerTurnEndDataVerify
	{
		// Token: 0x06028E1F RID: 167455 RVA: 0x0059E1B2 File Offset: 0x0059C3B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
