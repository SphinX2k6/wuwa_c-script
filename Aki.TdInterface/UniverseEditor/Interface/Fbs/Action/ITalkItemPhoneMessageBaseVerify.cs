using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC3 RID: 31427
	public static class ITalkItemPhoneMessageBaseVerify
	{
		// Token: 0x06038188 RID: 229768 RVA: 0x0078BC8A File Offset: 0x00789E8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
