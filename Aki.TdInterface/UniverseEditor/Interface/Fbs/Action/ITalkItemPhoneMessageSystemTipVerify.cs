using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F7 RID: 29431
	public static class ITalkItemPhoneMessageSystemTipVerify
	{
		// Token: 0x06034EBC RID: 216764 RVA: 0x0072AD66 File Offset: 0x00728F66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
