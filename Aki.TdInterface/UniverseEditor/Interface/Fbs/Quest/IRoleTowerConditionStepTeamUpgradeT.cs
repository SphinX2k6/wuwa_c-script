using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004521 RID: 17697
	public class IRoleTowerConditionStepTeamUpgradeT
	{
		// Token: 0x17007B1B RID: 31515
		// (get) Token: 0x060199D1 RID: 104913 RVA: 0x003A617E File Offset: 0x003A437E
		// (set) Token: 0x060199D2 RID: 104914 RVA: 0x003A6186 File Offset: 0x003A4386
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x060199D3 RID: 104915 RVA: 0x003A618F File Offset: 0x003A438F
		public IRoleTowerConditionStepTeamUpgradeT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
