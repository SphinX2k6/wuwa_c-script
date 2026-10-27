using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004230 RID: 16944
	public class ITrapDefenseConditionStepPreviewT
	{
		// Token: 0x17007854 RID: 30804
		// (get) Token: 0x060190D6 RID: 102614 RVA: 0x0039A976 File Offset: 0x00398B76
		// (set) Token: 0x060190D7 RID: 102615 RVA: 0x0039A97E File Offset: 0x00398B7E
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x060190D8 RID: 102616 RVA: 0x0039A987 File Offset: 0x00398B87
		public ITrapDefenseConditionStepPreviewT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
