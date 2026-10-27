using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004233 RID: 16947
	public class ITrapDefenseConditionStepRewardT
	{
		// Token: 0x17007857 RID: 30807
		// (get) Token: 0x060190E8 RID: 102632 RVA: 0x0039AAEE File Offset: 0x00398CEE
		// (set) Token: 0x060190E9 RID: 102633 RVA: 0x0039AAF6 File Offset: 0x00398CF6
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x060190EA RID: 102634 RVA: 0x0039AAFF File Offset: 0x00398CFF
		public ITrapDefenseConditionStepRewardT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
