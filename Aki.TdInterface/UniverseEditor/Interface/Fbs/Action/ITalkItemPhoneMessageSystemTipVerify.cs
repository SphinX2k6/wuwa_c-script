using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ACC RID: 31436
	public static class ITalkItemPhoneMessageSystemTipVerify
	{
		// Token: 0x060381C2 RID: 229826 RVA: 0x0078C1CA File Offset: 0x0078A3CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
