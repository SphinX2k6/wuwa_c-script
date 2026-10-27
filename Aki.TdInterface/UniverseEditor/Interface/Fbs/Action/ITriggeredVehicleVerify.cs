using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007480 RID: 29824
	public static class ITriggeredVehicleVerify
	{
		// Token: 0x06036329 RID: 221993 RVA: 0x0075E566 File Offset: 0x0075C766
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
