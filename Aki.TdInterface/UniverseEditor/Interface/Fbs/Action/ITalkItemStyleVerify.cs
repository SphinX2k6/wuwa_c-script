using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007300 RID: 29440
	public static class ITalkItemStyleVerify
	{
		// Token: 0x06034FEB RID: 217067 RVA: 0x0072E6B6 File Offset: 0x0072C8B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
