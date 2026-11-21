using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431A RID: 17178
	public class IKurotatoConditionStepChestRewardT
	{
		// Token: 0x170075A0 RID: 30112
		// (get) Token: 0x06018292 RID: 98962 RVA: 0x003722D2 File Offset: 0x003704D2
		// (set) Token: 0x06018293 RID: 98963 RVA: 0x003722DA File Offset: 0x003704DA
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06018294 RID: 98964 RVA: 0x003722E3 File Offset: 0x003704E3
		public IKurotatoConditionStepChestRewardT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
