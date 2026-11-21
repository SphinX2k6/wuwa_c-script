using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A12 RID: 31250
	public static class ISundialPuzzleGameplayVerify
	{
		// Token: 0x060370F3 RID: 225523 RVA: 0x0075BBAE File Offset: 0x00759DAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
