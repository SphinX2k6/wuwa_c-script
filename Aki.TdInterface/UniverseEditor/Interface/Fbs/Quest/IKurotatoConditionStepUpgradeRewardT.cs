using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432C RID: 17196
	public class IKurotatoConditionStepUpgradeRewardT
	{
		// Token: 0x170075B2 RID: 30130
		// (get) Token: 0x060182FE RID: 99070 RVA: 0x00372BA2 File Offset: 0x00370DA2
		// (set) Token: 0x060182FF RID: 99071 RVA: 0x00372BAA File Offset: 0x00370DAA
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06018300 RID: 99072 RVA: 0x00372BB3 File Offset: 0x00370DB3
		public IKurotatoConditionStepUpgradeRewardT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
