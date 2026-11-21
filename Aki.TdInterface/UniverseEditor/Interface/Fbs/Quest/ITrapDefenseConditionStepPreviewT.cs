using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200468C RID: 18060
	public class ITrapDefenseConditionStepPreviewT
	{
		// Token: 0x17007E85 RID: 32389
		// (get) Token: 0x0601A842 RID: 108610 RVA: 0x003C604E File Offset: 0x003C424E
		// (set) Token: 0x0601A843 RID: 108611 RVA: 0x003C6056 File Offset: 0x003C4256
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601A844 RID: 108612 RVA: 0x003C605F File Offset: 0x003C425F
		public ITrapDefenseConditionStepPreviewT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
