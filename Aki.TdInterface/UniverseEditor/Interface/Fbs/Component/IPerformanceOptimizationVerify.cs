using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571A RID: 22298
	public static class IPerformanceOptimizationVerify
	{
		// Token: 0x060254D9 RID: 152793 RVA: 0x00525BE2 File Offset: 0x00523DE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
