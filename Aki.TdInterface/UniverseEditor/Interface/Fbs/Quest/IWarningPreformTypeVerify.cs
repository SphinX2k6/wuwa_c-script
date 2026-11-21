using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F3 RID: 18163
	public static class IWarningPreformTypeVerify
	{
		// Token: 0x0601AB92 RID: 109458 RVA: 0x003CC386 File Offset: 0x003CA586
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
