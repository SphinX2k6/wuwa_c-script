using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200637C RID: 25468
	public static class IBvbAiTurnEndDataVerify
	{
		// Token: 0x0602B3F5 RID: 177141 RVA: 0x005E5DB2 File Offset: 0x005E3FB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
