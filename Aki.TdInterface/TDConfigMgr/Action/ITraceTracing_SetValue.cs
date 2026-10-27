using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD7 RID: 8151
	public class ITraceTracing_SetValue
	{
		// Token: 0x04006C32 RID: 27698
		public ESimpleGameplayType Type;

		// Token: 0x04006C33 RID: 27699
		public ETraceTracingImageType ImageResourceType;

		// Token: 0x04006C34 RID: 27700
		[Nullable(1)]
		public ITraceTracingGridBoard BoardConfig;

		// Token: 0x04006C35 RID: 27701
		public int StepLimit;

		// Token: 0x04006C36 RID: 27702
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITraceTracingMaxStepRewardRuleItem> MaxStepRewardRule;

		// Token: 0x04006C37 RID: 27703
		public bool? RemainUiAfterCompletion;
	}
}
