using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D4E RID: 23886
	public static class IPlaneMovementOptimizationConfigVerify
	{
		// Token: 0x06027C26 RID: 162854 RVA: 0x00570BA6 File Offset: 0x0056EDA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
