using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007306 RID: 29446
	public static class ITalkItemStylePhoneSendErrorVerify
	{
		// Token: 0x0603500F RID: 217103 RVA: 0x0072E9A6 File Offset: 0x0072CBA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
