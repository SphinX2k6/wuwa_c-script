using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DD RID: 21725
	public static class ICircuitConnectLayoutBaseVerify
	{
		// Token: 0x060224B8 RID: 140472 RVA: 0x004BA416 File Offset: 0x004B8616
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
