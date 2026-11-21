using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004516 RID: 17686
	public static class IRoleTowerConditionStepBattleVerify
	{
		// Token: 0x0601998C RID: 104844 RVA: 0x003A5BBE File Offset: 0x003A3DBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
