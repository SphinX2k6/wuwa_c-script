using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200455B RID: 17755
	public static class ISheriffReasoningBoardConfigVerify
	{
		// Token: 0x06019D1B RID: 105755 RVA: 0x003AF1FE File Offset: 0x003AD3FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
