using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004311 RID: 17169
	public class IKurotatoConditionStepBaseT
	{
		// Token: 0x17007598 RID: 30104
		// (get) Token: 0x06018254 RID: 98900 RVA: 0x00371D12 File Offset: 0x0036FF12
		// (set) Token: 0x06018255 RID: 98901 RVA: 0x00371D1A File Offset: 0x0036FF1A
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06018256 RID: 98902 RVA: 0x00371D23 File Offset: 0x0036FF23
		public IKurotatoConditionStepBaseT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
