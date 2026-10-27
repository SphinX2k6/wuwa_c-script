using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040DA RID: 16602
	public class IRoleTowerConditionStepPrepareT
	{
		// Token: 0x1700750F RID: 29967
		// (get) Token: 0x0601830C RID: 99084 RVA: 0x0037BF3E File Offset: 0x0037A13E
		// (set) Token: 0x0601830D RID: 99085 RVA: 0x0037BF46 File Offset: 0x0037A146
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x0601830E RID: 99086 RVA: 0x0037BF4F File Offset: 0x0037A14F
		public IRoleTowerConditionStepPrepareT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
