using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F90 RID: 20368
	public static class IChargingDeviceVerify
	{
		// Token: 0x060205EA RID: 132586 RVA: 0x00480E4C File Offset: 0x0047F04C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
