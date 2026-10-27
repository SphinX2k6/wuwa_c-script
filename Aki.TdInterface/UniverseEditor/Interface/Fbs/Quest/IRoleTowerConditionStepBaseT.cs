using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040CE RID: 16590
	public class IRoleTowerConditionStepBaseT
	{
		// Token: 0x17007504 RID: 29956
		// (get) Token: 0x060182C2 RID: 99010 RVA: 0x0037B8C6 File Offset: 0x00379AC6
		// (set) Token: 0x060182C3 RID: 99011 RVA: 0x0037B8CE File Offset: 0x00379ACE
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x060182C4 RID: 99012 RVA: 0x0037B8D7 File Offset: 0x00379AD7
		public IRoleTowerConditionStepBaseT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
