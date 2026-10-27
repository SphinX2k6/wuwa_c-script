using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004236 RID: 16950
	public class ITrapDefenseConditionStepSpawnMonsterT
	{
		// Token: 0x1700785A RID: 30810
		// (get) Token: 0x060190FA RID: 102650 RVA: 0x0039AC66 File Offset: 0x00398E66
		// (set) Token: 0x060190FB RID: 102651 RVA: 0x0039AC6E File Offset: 0x00398E6E
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x060190FC RID: 102652 RVA: 0x0039AC77 File Offset: 0x00398E77
		public ITrapDefenseConditionStepSpawnMonsterT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
