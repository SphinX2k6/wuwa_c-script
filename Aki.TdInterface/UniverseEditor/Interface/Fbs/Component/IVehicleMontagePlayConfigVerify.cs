using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B25 RID: 23333
	public static class IVehicleMontagePlayConfigVerify
	{
		// Token: 0x06027E15 RID: 163349 RVA: 0x0057C0D8 File Offset: 0x0057A2D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
