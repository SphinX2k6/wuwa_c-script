using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CD RID: 21453
	public static class IHookLockScreenDetectTypeBaseVerify
	{
		// Token: 0x06023358 RID: 144216 RVA: 0x004E0586 File Offset: 0x004DE786
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
