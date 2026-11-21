using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004522 RID: 17698
	public static class IRoleTowerConditionStepTeamUpgradeVerify
	{
		// Token: 0x060199D4 RID: 104916 RVA: 0x003A619E File Offset: 0x003A439E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
