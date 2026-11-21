using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C68 RID: 23656
	public static class IPasserbyNpcExitIntervalBaseVerify
	{
		// Token: 0x060273F6 RID: 160758 RVA: 0x005605B6 File Offset: 0x0055E7B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
