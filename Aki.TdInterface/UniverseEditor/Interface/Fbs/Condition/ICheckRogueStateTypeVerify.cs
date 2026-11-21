using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005000 RID: 20480
	public static class ICheckRogueStateTypeVerify
	{
		// Token: 0x0601FF62 RID: 130914 RVA: 0x0046FBA2 File Offset: 0x0046DDA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
