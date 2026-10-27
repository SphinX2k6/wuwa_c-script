using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B3A RID: 19258
	public static class ICheckSyncLevelPlayCompleteNumberVerify
	{
		// Token: 0x0601E4F1 RID: 124145 RVA: 0x0043F260 File Offset: 0x0043D460
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
