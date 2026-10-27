using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590A RID: 22794
	public static class ISharingVehicleFeatureVerify
	{
		// Token: 0x0602685F RID: 157791 RVA: 0x0054EA1C File Offset: 0x0054CC1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
