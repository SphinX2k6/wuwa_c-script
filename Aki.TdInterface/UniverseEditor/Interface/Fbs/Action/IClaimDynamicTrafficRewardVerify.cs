using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200637E RID: 25470
	public static class IClaimDynamicTrafficRewardVerify
	{
		// Token: 0x0602C0E5 RID: 180453 RVA: 0x0060D4FE File Offset: 0x0060B6FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
