using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005747 RID: 22343
	public static class IPlaneMovementOptimizationConfigVerify
	{
		// Token: 0x06025706 RID: 153350 RVA: 0x0052AA1A File Offset: 0x00528C1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
