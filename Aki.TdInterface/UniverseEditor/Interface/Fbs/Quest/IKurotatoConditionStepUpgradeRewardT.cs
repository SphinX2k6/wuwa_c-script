using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EEE RID: 16110
	public class IKurotatoConditionStepUpgradeRewardT
	{
		// Token: 0x17006FC3 RID: 28611
		// (get) Token: 0x06016CA7 RID: 93351 RVA: 0x003499D6 File Offset: 0x00347BD6
		// (set) Token: 0x06016CA8 RID: 93352 RVA: 0x003499DE File Offset: 0x00347BDE
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016CA9 RID: 93353 RVA: 0x003499E7 File Offset: 0x00347BE7
		public IKurotatoConditionStepUpgradeRewardT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
