using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED9 RID: 16089
	public class IKurotatoConditionStepBattleT
	{
		// Token: 0x17006FAE RID: 28590
		// (get) Token: 0x06016C29 RID: 93225 RVA: 0x00348F8E File Offset: 0x0034718E
		// (set) Token: 0x06016C2A RID: 93226 RVA: 0x00348F96 File Offset: 0x00347196
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C2B RID: 93227 RVA: 0x00348F9F File Offset: 0x0034719F
		public IKurotatoConditionStepBattleT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
