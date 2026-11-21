using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005953 RID: 22867
	public static class IHookLockScreenDetectTypeBaseVerify
	{
		// Token: 0x06025410 RID: 152592 RVA: 0x0051D5B2 File Offset: 0x0051B7B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
