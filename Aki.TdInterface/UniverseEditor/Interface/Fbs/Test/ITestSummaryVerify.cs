using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003B77 RID: 15223
	public static class ITestSummaryVerify
	{
		// Token: 0x06014D76 RID: 85366 RVA: 0x00306B34 File Offset: 0x00304D34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
