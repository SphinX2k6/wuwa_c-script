using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040DD RID: 16605
	public class IRoleTowerConditionStepSettleT
	{
		// Token: 0x17007512 RID: 29970
		// (get) Token: 0x0601831E RID: 99102 RVA: 0x0037C0B6 File Offset: 0x0037A2B6
		// (set) Token: 0x0601831F RID: 99103 RVA: 0x0037C0BE File Offset: 0x0037A2BE
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x06018320 RID: 99104 RVA: 0x0037C0C7 File Offset: 0x0037A2C7
		public IRoleTowerConditionStepSettleT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
