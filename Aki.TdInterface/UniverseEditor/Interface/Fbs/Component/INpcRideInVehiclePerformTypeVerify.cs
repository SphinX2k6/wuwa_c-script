using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005649 RID: 22089
	public static class INpcRideInVehiclePerformTypeVerify
	{
		// Token: 0x06024B92 RID: 150418 RVA: 0x005115A3 File Offset: 0x0050F7A3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
