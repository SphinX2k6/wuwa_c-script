using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BC RID: 27068
	public static class IItemFoundationMatchVerify
	{
		// Token: 0x0602F4C2 RID: 193730 RVA: 0x00671056 File Offset: 0x0066F256
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
