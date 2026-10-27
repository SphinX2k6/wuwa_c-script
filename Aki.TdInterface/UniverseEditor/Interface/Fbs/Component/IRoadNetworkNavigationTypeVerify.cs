using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005872 RID: 22642
	public static class IRoadNetworkNavigationTypeVerify
	{
		// Token: 0x06026279 RID: 156281 RVA: 0x00542D0A File Offset: 0x00540F0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
