using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723D RID: 29245
	public static class ISundialPuzzleGameplayVerify
	{
		// Token: 0x06033DF1 RID: 212465 RVA: 0x006FA84E File Offset: 0x006F8A4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
