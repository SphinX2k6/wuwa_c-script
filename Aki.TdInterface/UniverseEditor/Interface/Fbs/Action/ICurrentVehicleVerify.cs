using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F1 RID: 25841
	public static class ICurrentVehicleVerify
	{
		// Token: 0x0602CD3C RID: 183612 RVA: 0x00628C26 File Offset: 0x00626E26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
