using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005432 RID: 21554
	public static class IBattleVehicleFeatureVerify
	{
		// Token: 0x06021CA1 RID: 138401 RVA: 0x004A8856 File Offset: 0x004A6A56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
