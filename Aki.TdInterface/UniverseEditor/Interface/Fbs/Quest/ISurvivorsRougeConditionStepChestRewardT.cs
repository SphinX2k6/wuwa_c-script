using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415B RID: 16731
	public class ISurvivorsRougeConditionStepChestRewardT
	{
		// Token: 0x1700768E RID: 30350
		// (get) Token: 0x06018930 RID: 100656 RVA: 0x0038A8BA File Offset: 0x00388ABA
		// (set) Token: 0x06018931 RID: 100657 RVA: 0x0038A8C2 File Offset: 0x00388AC2
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06018932 RID: 100658 RVA: 0x0038A8CB File Offset: 0x00388ACB
		public ISurvivorsRougeConditionStepChestRewardT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
