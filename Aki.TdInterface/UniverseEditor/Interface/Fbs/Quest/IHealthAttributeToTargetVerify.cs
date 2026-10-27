using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E98 RID: 16024
	public static class IHealthAttributeToTargetVerify
	{
		// Token: 0x06016A01 RID: 92673 RVA: 0x00344BA8 File Offset: 0x00342DA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
