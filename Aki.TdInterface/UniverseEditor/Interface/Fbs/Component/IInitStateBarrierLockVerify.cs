using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A4 RID: 22948
	public static class IInitStateBarrierLockVerify
	{
		// Token: 0x06025698 RID: 153240 RVA: 0x00521F2A File Offset: 0x0052012A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
