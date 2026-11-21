using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005015 RID: 20501
	public static class ICheckSpringFestivalGuessJokerFirstCompleteVerify
	{
		// Token: 0x06020010 RID: 131088 RVA: 0x00470EB0 File Offset: 0x0046F0B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
