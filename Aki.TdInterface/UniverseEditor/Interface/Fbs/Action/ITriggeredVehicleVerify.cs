using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C73 RID: 31859
	public static class ITriggeredVehicleVerify
	{
		// Token: 0x06039712 RID: 235282 RVA: 0x007C1292 File Offset: 0x007BF492
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
