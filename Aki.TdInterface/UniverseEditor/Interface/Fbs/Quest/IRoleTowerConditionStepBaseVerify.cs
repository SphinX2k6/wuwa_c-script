using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040CF RID: 16591
	public static class IRoleTowerConditionStepBaseVerify
	{
		// Token: 0x060182C5 RID: 99013 RVA: 0x0037B8E6 File Offset: 0x00379AE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
