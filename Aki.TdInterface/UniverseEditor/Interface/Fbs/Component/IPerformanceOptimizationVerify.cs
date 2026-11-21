using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D21 RID: 23841
	public static class IPerformanceOptimizationVerify
	{
		// Token: 0x060279E8 RID: 162280 RVA: 0x0056B8EA File Offset: 0x00569AEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
