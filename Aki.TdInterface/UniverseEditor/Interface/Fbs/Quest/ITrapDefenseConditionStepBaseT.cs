using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004680 RID: 18048
	public class ITrapDefenseConditionStepBaseT
	{
		// Token: 0x17007E7A RID: 32378
		// (get) Token: 0x0601A7F8 RID: 108536 RVA: 0x003C59D6 File Offset: 0x003C3BD6
		// (set) Token: 0x0601A7F9 RID: 108537 RVA: 0x003C59DE File Offset: 0x003C3BDE
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601A7FA RID: 108538 RVA: 0x003C59E7 File Offset: 0x003C3BE7
		public ITrapDefenseConditionStepBaseT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
