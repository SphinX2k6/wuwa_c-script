using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ADB RID: 31451
	public static class ITalkItemStylePhoneSendErrorVerify
	{
		// Token: 0x06038315 RID: 230165 RVA: 0x0078FE0A File Offset: 0x0078E00A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
