using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D4 RID: 16596
	public class IRoleTowerConditionStepBattleT
	{
		// Token: 0x17007509 RID: 29961
		// (get) Token: 0x060182E8 RID: 99048 RVA: 0x0037BC4E File Offset: 0x00379E4E
		// (set) Token: 0x060182E9 RID: 99049 RVA: 0x0037BC56 File Offset: 0x00379E56
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x060182EA RID: 99050 RVA: 0x0037BC5F File Offset: 0x00379E5F
		public IRoleTowerConditionStepBattleT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
