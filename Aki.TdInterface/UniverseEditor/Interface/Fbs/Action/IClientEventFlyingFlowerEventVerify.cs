using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006399 RID: 25497
	public static class IClientEventFlyingFlowerEventVerify
	{
		// Token: 0x0602C1D0 RID: 180688 RVA: 0x0060F236 File Offset: 0x0060D436
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
