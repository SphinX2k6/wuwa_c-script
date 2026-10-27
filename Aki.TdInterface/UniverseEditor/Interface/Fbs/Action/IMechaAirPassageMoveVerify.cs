using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7B RID: 27259
	public static class IMechaAirPassageMoveVerify
	{
		// Token: 0x0602FC1E RID: 195614 RVA: 0x0067F854 File Offset: 0x0067DA54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
