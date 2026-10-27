using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673A RID: 26426
	public static class IExitVehicleTypeVerify
	{
		// Token: 0x0602DF7C RID: 188284 RVA: 0x006487B2 File Offset: 0x006469B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
