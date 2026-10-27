using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005170 RID: 20848
	public static class IEntityCategoryVerify
	{
		// Token: 0x06021B13 RID: 138003 RVA: 0x004ACB5C File Offset: 0x004AAD5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 46, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 56, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
