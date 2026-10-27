using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040DE RID: 16606
	public static class IRoleTowerConditionStepSettleVerify
	{
		// Token: 0x06018321 RID: 99105 RVA: 0x0037C0D6 File Offset: 0x0037A2D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
