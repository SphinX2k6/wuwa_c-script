using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EDC RID: 16092
	public class IKurotatoConditionStepChestRewardT
	{
		// Token: 0x17006FB1 RID: 28593
		// (get) Token: 0x06016C3B RID: 93243 RVA: 0x00349106 File Offset: 0x00347306
		// (set) Token: 0x06016C3C RID: 93244 RVA: 0x0034910E File Offset: 0x0034730E
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C3D RID: 93245 RVA: 0x00349117 File Offset: 0x00347317
		public IKurotatoConditionStepChestRewardT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
