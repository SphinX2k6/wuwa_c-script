using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200451F RID: 17695
	public static class IRoleTowerConditionStepSettleVerify
	{
		// Token: 0x060199C2 RID: 104898 RVA: 0x003A6026 File Offset: 0x003A4226
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
