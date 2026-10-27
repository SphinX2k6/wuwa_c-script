using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E5 RID: 24805
	public static class IActorLookAtOtherActorVerify
	{
		// Token: 0x0602A5F7 RID: 173559 RVA: 0x005D6CB8 File Offset: 0x005D4EB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
