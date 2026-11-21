using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FEB RID: 20459
	public static class ICheckPreloadCompleteObjectTypeVerify
	{
		// Token: 0x0601FEC6 RID: 130758 RVA: 0x0046EBFA File Offset: 0x0046CDFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
