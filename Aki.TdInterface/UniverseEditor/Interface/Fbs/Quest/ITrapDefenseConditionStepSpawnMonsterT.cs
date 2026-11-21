using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004692 RID: 18066
	public class ITrapDefenseConditionStepSpawnMonsterT
	{
		// Token: 0x17007E8B RID: 32395
		// (get) Token: 0x0601A866 RID: 108646 RVA: 0x003C633E File Offset: 0x003C453E
		// (set) Token: 0x0601A867 RID: 108647 RVA: 0x003C6346 File Offset: 0x003C4546
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601A868 RID: 108648 RVA: 0x003C634F File Offset: 0x003C454F
		public ITrapDefenseConditionStepSpawnMonsterT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
