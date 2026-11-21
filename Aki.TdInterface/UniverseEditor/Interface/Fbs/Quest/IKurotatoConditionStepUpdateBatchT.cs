using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004329 RID: 17193
	public class IKurotatoConditionStepUpdateBatchT
	{
		// Token: 0x170075AF RID: 30127
		// (get) Token: 0x060182EC RID: 99052 RVA: 0x00372A2A File Offset: 0x00370C2A
		// (set) Token: 0x060182ED RID: 99053 RVA: 0x00372A32 File Offset: 0x00370C32
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x060182EE RID: 99054 RVA: 0x00372A3B File Offset: 0x00370C3B
		public IKurotatoConditionStepUpdateBatchT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
