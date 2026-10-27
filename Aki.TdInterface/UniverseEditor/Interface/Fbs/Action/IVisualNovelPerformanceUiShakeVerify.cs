using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CD RID: 30157
	public static class IVisualNovelPerformanceUiShakeVerify
	{
		// Token: 0x06036EE5 RID: 224997 RVA: 0x00774A70 File Offset: 0x00772C70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
