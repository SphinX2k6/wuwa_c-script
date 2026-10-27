using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004224 RID: 16932
	public class ITrapDefenseConditionStepBaseT
	{
		// Token: 0x17007849 RID: 30793
		// (get) Token: 0x0601908C RID: 102540 RVA: 0x0039A2FE File Offset: 0x003984FE
		// (set) Token: 0x0601908D RID: 102541 RVA: 0x0039A306 File Offset: 0x00398506
		public ETrapDefenseConditionStep Type { get; set; }

		// Token: 0x0601908E RID: 102542 RVA: 0x0039A30F File Offset: 0x0039850F
		public ITrapDefenseConditionStepBaseT()
		{
			this.Type = ETrapDefenseConditionStep.Reward;
		}
	}
}
