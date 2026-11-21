using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004320 RID: 17184
	public class IKurotatoConditionStepPrepareT
	{
		// Token: 0x170075A6 RID: 30118
		// (get) Token: 0x060182B6 RID: 98998 RVA: 0x003725C2 File Offset: 0x003707C2
		// (set) Token: 0x060182B7 RID: 98999 RVA: 0x003725CA File Offset: 0x003707CA
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x060182B8 RID: 99000 RVA: 0x003725D3 File Offset: 0x003707D3
		public IKurotatoConditionStepPrepareT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
