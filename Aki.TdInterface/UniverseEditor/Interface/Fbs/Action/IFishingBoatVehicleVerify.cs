using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E47 RID: 28231
	public static class IFishingBoatVehicleVerify
	{
		// Token: 0x06030C36 RID: 199734 RVA: 0x0069E3F2 File Offset: 0x0069C5F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
