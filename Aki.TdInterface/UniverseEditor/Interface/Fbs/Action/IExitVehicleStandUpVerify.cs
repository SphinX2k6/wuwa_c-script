using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006734 RID: 26420
	public static class IExitVehicleStandUpVerify
	{
		// Token: 0x0602DF50 RID: 188240 RVA: 0x006482A6 File Offset: 0x006464A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
