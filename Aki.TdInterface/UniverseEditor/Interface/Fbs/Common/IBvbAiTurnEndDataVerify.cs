using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D45 RID: 23877
	public static class IBvbAiTurnEndDataVerify
	{
		// Token: 0x06028D8B RID: 167307 RVA: 0x0059D342 File Offset: 0x0059B542
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
