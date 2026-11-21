using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F9 RID: 26361
	public static class IActiveAntiGravitySafePointVerify
	{
		// Token: 0x0602CA20 RID: 182816 RVA: 0x0061B97A File Offset: 0x00619B7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
