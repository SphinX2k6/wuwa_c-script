using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200468F RID: 18063
	public class ITrapDefenseConditionStepRewardT
	{
		// Token: 0x17007E88 RID: 32392
		// (get) Token: 0x0601A854 RID: 108628 RVA: 0x003C61C6 File Offset: 0x003C43C6
		// (set) Token: 0x0601A855 RID: 108629 RVA: 0x003C61CE File Offset: 0x003C43CE
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601A856 RID: 108630 RVA: 0x003C61D7 File Offset: 0x003C43D7
		public ITrapDefenseConditionStepRewardT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
