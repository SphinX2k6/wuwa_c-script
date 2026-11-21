using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004686 RID: 18054
	public class ITrapDefenseConditionStepLoadAndRestoreMapT
	{
		// Token: 0x17007E7F RID: 32383
		// (get) Token: 0x0601A81E RID: 108574 RVA: 0x003C5D5E File Offset: 0x003C3F5E
		// (set) Token: 0x0601A81F RID: 108575 RVA: 0x003C5D66 File Offset: 0x003C3F66
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601A820 RID: 108576 RVA: 0x003C5D6F File Offset: 0x003C3F6F
		public ITrapDefenseConditionStepLoadAndRestoreMapT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
