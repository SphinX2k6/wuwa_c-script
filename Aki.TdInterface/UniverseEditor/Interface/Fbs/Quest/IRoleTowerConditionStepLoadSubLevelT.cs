using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D7 RID: 16599
	public class IRoleTowerConditionStepLoadSubLevelT
	{
		// Token: 0x1700750C RID: 29964
		// (get) Token: 0x060182FA RID: 99066 RVA: 0x0037BDC6 File Offset: 0x00379FC6
		// (set) Token: 0x060182FB RID: 99067 RVA: 0x0037BDCE File Offset: 0x00379FCE
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x060182FC RID: 99068 RVA: 0x0037BDD7 File Offset: 0x00379FD7
		public IRoleTowerConditionStepLoadSubLevelT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
