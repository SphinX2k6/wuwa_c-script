using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A3 RID: 22179
	public static class IOnMoveWithSplineEndAttachTimingVerify
	{
		// Token: 0x06025045 RID: 151621 RVA: 0x0051C9A4 File Offset: 0x0051ABA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
