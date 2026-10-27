using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200498A RID: 18826
	public static class ICheckAvailableSunSpiritCountVerify
	{
		// Token: 0x0601D5AB RID: 120235 RVA: 0x00423864 File Offset: 0x00421A64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
