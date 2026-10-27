using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D5 RID: 16597
	public static class IRoleTowerConditionStepBattleVerify
	{
		// Token: 0x060182EB RID: 99051 RVA: 0x0037BC6E File Offset: 0x00379E6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
