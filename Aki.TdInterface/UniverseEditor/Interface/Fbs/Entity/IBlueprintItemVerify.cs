using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004780 RID: 18304
	public static class IBlueprintItemVerify
	{
		// Token: 0x0601C2F6 RID: 115446 RVA: 0x003FDD34 File Offset: 0x003FBF34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 2UL, 2UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
