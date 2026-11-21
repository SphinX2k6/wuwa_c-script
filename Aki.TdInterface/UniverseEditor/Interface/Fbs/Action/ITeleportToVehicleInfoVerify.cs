using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B80 RID: 31616
	public static class ITeleportToVehicleInfoVerify
	{
		// Token: 0x06038EFB RID: 233211 RVA: 0x007B2256 File Offset: 0x007B0456
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
