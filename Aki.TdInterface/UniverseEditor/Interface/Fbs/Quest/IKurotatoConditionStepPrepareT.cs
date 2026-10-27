using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE2 RID: 16098
	public class IKurotatoConditionStepPrepareT
	{
		// Token: 0x17006FB7 RID: 28599
		// (get) Token: 0x06016C5F RID: 93279 RVA: 0x003493F6 File Offset: 0x003475F6
		// (set) Token: 0x06016C60 RID: 93280 RVA: 0x003493FE File Offset: 0x003475FE
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C61 RID: 93281 RVA: 0x00349407 File Offset: 0x00347607
		public IKurotatoConditionStepPrepareT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
