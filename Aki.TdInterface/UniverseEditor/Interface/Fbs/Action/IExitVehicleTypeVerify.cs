using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBA RID: 28090
	public static class IExitVehicleTypeVerify
	{
		// Token: 0x060307C2 RID: 198594 RVA: 0x00695EF6 File Offset: 0x006940F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
