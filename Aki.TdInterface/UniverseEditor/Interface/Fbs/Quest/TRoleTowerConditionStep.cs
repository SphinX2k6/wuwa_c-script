using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430B RID: 17163
	public enum TRoleTowerConditionStep : byte
	{
		// Token: 0x0400C092 RID: 49298
		NONE,
		// Token: 0x0400C093 RID: 49299
		IRoleTowerConditionStepBattle,
		// Token: 0x0400C094 RID: 49300
		IRoleTowerConditionStepLoadSubLevel,
		// Token: 0x0400C095 RID: 49301
		IRoleTowerConditionStepPrepare,
		// Token: 0x0400C096 RID: 49302
		IRoleTowerConditionStepSettle,
		// Token: 0x0400C097 RID: 49303
		IRoleTowerConditionStepTeamUpgrade
	}
}
