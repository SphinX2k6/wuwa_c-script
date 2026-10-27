using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004882 RID: 18562
	public static class ILaunchSettingShowInMainEditorVerify
	{
		// Token: 0x0601CF3B RID: 118587 RVA: 0x004173E0 File Offset: 0x004155E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 46, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 64, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
