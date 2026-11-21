using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F1 RID: 25073
	public static class IWuWaGoSpikeTrapVerify
	{
		// Token: 0x0602AA8C RID: 174732 RVA: 0x005D1234 File Offset: 0x005CF434
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
