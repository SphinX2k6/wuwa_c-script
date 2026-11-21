using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200451E RID: 17694
	public class IRoleTowerConditionStepSettleT
	{
		// Token: 0x17007B18 RID: 31512
		// (get) Token: 0x060199BF RID: 104895 RVA: 0x003A6006 File Offset: 0x003A4206
		// (set) Token: 0x060199C0 RID: 104896 RVA: 0x003A600E File Offset: 0x003A420E
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x060199C1 RID: 104897 RVA: 0x003A6017 File Offset: 0x003A4217
		public IRoleTowerConditionStepSettleT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
