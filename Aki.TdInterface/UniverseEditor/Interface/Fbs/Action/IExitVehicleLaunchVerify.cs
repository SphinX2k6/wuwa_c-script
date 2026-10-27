using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672E RID: 26414
	public static class IExitVehicleLaunchVerify
	{
		// Token: 0x0602DF2C RID: 188204 RVA: 0x00647FB6 File Offset: 0x006461B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
