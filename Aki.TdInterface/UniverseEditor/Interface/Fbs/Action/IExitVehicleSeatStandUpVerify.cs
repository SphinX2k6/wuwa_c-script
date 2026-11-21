using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB1 RID: 28081
	public static class IExitVehicleSeatStandUpVerify
	{
		// Token: 0x06030784 RID: 198532 RVA: 0x00695872 File Offset: 0x00693A72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
