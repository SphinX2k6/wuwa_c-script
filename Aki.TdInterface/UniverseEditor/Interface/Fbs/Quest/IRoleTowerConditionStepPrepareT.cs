using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200451B RID: 17691
	public class IRoleTowerConditionStepPrepareT
	{
		// Token: 0x17007B15 RID: 31509
		// (get) Token: 0x060199AD RID: 104877 RVA: 0x003A5E8E File Offset: 0x003A408E
		// (set) Token: 0x060199AE RID: 104878 RVA: 0x003A5E96 File Offset: 0x003A4096
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x060199AF RID: 104879 RVA: 0x003A5E9F File Offset: 0x003A409F
		public IRoleTowerConditionStepPrepareT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
