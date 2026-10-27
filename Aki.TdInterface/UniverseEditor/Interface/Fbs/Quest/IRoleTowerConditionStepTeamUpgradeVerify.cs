using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E1 RID: 16609
	public static class IRoleTowerConditionStepTeamUpgradeVerify
	{
		// Token: 0x06018333 RID: 99123 RVA: 0x0037C24E File Offset: 0x0037A44E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
