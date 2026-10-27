using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006731 RID: 26417
	public static class IExitVehicleSeatStandUpVerify
	{
		// Token: 0x0602DF3E RID: 188222 RVA: 0x0064812E File Offset: 0x0064632E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
