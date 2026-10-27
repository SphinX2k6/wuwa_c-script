using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EEB RID: 16107
	public class IKurotatoConditionStepUpdateBatchT
	{
		// Token: 0x17006FC0 RID: 28608
		// (get) Token: 0x06016C95 RID: 93333 RVA: 0x0034985E File Offset: 0x00347A5E
		// (set) Token: 0x06016C96 RID: 93334 RVA: 0x00349866 File Offset: 0x00347A66
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C97 RID: 93335 RVA: 0x0034986F File Offset: 0x00347A6F
		public IKurotatoConditionStepUpdateBatchT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
