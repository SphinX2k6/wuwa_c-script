using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411A RID: 16666
	public static class IArcadeGameplayBaseVerify
	{
		// Token: 0x06016DEC RID: 93676 RVA: 0x00344186 File Offset: 0x00342386
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
