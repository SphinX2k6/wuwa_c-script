using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE5 RID: 16101
	public class IKurotatoConditionStepSaveRoleT
	{
		// Token: 0x17006FBA RID: 28602
		// (get) Token: 0x06016C71 RID: 93297 RVA: 0x0034956E File Offset: 0x0034776E
		// (set) Token: 0x06016C72 RID: 93298 RVA: 0x00349576 File Offset: 0x00347776
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C73 RID: 93299 RVA: 0x0034957F File Offset: 0x0034777F
		public IKurotatoConditionStepSaveRoleT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
