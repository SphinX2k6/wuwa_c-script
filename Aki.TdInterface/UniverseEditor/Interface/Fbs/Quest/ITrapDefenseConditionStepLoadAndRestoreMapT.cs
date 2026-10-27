using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422A RID: 16938
	public class ITrapDefenseConditionStepLoadAndRestoreMapT
	{
		// Token: 0x1700784E RID: 30798
		// (get) Token: 0x060190B2 RID: 102578 RVA: 0x0039A686 File Offset: 0x00398886
		// (set) Token: 0x060190B3 RID: 102579 RVA: 0x0039A68E File Offset: 0x0039888E
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x060190B4 RID: 102580 RVA: 0x0039A697 File Offset: 0x00398897
		public ITrapDefenseConditionStepLoadAndRestoreMapT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
