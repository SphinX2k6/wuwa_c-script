using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F64 RID: 20324
	public static class ICheckIsPlayerHoldingHandsVerify
	{
		// Token: 0x0601FA0C RID: 129548 RVA: 0x00465F4A File Offset: 0x0046414A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
