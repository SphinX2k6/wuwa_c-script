using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004689 RID: 18057
	public class ITrapDefenseConditionStepMapChangeT
	{
		// Token: 0x17007E82 RID: 32386
		// (get) Token: 0x0601A830 RID: 108592 RVA: 0x003C5ED6 File Offset: 0x003C40D6
		// (set) Token: 0x0601A831 RID: 108593 RVA: 0x003C5EDE File Offset: 0x003C40DE
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601A832 RID: 108594 RVA: 0x003C5EE7 File Offset: 0x003C40E7
		public ITrapDefenseConditionStepMapChangeT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
