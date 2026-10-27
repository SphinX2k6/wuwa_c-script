using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007399 RID: 29593
	public static class ITeleportToVehicleInfoVerify
	{
		// Token: 0x06035B60 RID: 220000 RVA: 0x0074FD16 File Offset: 0x0074DF16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
