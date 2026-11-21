using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004511 RID: 17681
	public enum IRoleTowerConditionStepBase_Union : byte
	{
		// Token: 0x0400C650 RID: 50768
		NONE,
		// Token: 0x0400C651 RID: 50769
		IRoleTowerConditionStepBase,
		// Token: 0x0400C652 RID: 50770
		IRoleTowerConditionStepPrepare,
		// Token: 0x0400C653 RID: 50771
		IRoleTowerConditionStepBattle,
		// Token: 0x0400C654 RID: 50772
		IRoleTowerConditionStepSettle,
		// Token: 0x0400C655 RID: 50773
		IRoleTowerConditionStepTeamUpgrade,
		// Token: 0x0400C656 RID: 50774
		IRoleTowerConditionStepLoadSubLevel
	}
}
