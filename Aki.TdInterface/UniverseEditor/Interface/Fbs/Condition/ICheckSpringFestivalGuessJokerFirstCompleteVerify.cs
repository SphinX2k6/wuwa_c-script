using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B2E RID: 19246
	public static class ICheckSpringFestivalGuessJokerFirstCompleteVerify
	{
		// Token: 0x0601E485 RID: 124037 RVA: 0x0043E704 File Offset: 0x0043C904
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
