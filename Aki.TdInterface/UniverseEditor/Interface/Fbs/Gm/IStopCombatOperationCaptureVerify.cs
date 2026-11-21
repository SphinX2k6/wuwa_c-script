using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B18 RID: 19224
	public static class IStopCombatOperationCaptureVerify
	{
		// Token: 0x0601CFC5 RID: 118725 RVA: 0x00413616 File Offset: 0x00411816
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
