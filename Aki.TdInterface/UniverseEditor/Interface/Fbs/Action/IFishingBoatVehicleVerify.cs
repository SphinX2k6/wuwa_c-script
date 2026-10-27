using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C7 RID: 26567
	public static class IFishingBoatVehicleVerify
	{
		// Token: 0x0602E3F0 RID: 189424 RVA: 0x00650CAE File Offset: 0x0064EEAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
