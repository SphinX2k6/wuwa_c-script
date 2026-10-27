using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E0 RID: 16608
	public class IRoleTowerConditionStepTeamUpgradeT
	{
		// Token: 0x17007515 RID: 29973
		// (get) Token: 0x06018330 RID: 99120 RVA: 0x0037C22E File Offset: 0x0037A42E
		// (set) Token: 0x06018331 RID: 99121 RVA: 0x0037C236 File Offset: 0x0037A436
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x06018332 RID: 99122 RVA: 0x0037C23F File Offset: 0x0037A43F
		public IRoleTowerConditionStepTeamUpgradeT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
