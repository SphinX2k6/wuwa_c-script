using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D2A RID: 23850
	public static class IPerformanceVehicleFeatureVerify
	{
		// Token: 0x06027A38 RID: 162360 RVA: 0x0056C2A7 File Offset: 0x0056A4A7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
