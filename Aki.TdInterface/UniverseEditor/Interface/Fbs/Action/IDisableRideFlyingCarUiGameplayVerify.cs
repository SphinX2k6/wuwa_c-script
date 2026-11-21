using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5E RID: 27742
	public static class IDisableRideFlyingCarUiGameplayVerify
	{
		// Token: 0x0602FC75 RID: 195701 RVA: 0x00681DA6 File Offset: 0x0067FFA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
