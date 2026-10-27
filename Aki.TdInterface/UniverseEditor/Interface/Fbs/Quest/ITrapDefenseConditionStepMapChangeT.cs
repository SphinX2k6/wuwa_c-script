using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422D RID: 16941
	public class ITrapDefenseConditionStepMapChangeT
	{
		// Token: 0x17007851 RID: 30801
		// (get) Token: 0x060190C4 RID: 102596 RVA: 0x0039A7FE File Offset: 0x003989FE
		// (set) Token: 0x060190C5 RID: 102597 RVA: 0x0039A806 File Offset: 0x00398A06
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x060190C6 RID: 102598 RVA: 0x0039A80F File Offset: 0x00398A0F
		public ITrapDefenseConditionStepMapChangeT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
