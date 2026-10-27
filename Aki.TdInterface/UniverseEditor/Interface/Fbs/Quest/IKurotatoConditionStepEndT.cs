using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EDF RID: 16095
	public class IKurotatoConditionStepEndT
	{
		// Token: 0x17006FB4 RID: 28596
		// (get) Token: 0x06016C4D RID: 93261 RVA: 0x0034927E File Offset: 0x0034747E
		// (set) Token: 0x06016C4E RID: 93262 RVA: 0x00349286 File Offset: 0x00347486
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C4F RID: 93263 RVA: 0x0034928F File Offset: 0x0034748F
		public IKurotatoConditionStepEndT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
