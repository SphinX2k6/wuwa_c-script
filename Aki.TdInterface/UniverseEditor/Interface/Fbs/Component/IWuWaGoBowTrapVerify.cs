using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B3 RID: 25011
	public static class IWuWaGoBowTrapVerify
	{
		// Token: 0x0602A834 RID: 174132 RVA: 0x005CC46A File Offset: 0x005CA66A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
