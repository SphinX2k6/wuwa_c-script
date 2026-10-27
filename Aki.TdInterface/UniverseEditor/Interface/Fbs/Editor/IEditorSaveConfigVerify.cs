using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200486A RID: 18538
	public static class IEditorSaveConfigVerify
	{
		// Token: 0x0601CCBB RID: 117947 RVA: 0x00411BD4 File Offset: 0x0040FDD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 38, false) && verifier.VerifyField(tablePos, 40, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 42, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 46, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 50, false) && verifier.VerifyField(tablePos, 52, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 60, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
