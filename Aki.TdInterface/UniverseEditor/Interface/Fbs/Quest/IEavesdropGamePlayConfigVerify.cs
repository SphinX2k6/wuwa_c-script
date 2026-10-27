using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF0 RID: 15856
	public static class IEavesdropGamePlayConfigVerify
	{
		// Token: 0x060162B8 RID: 90808 RVA: 0x00333D64 File Offset: 0x00331F64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
