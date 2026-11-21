using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221E RID: 8734
	public class ITraceTracing_SetValue
	{
		// Token: 0x04007234 RID: 29236
		public ESimpleGameplayType Type;

		// Token: 0x04007235 RID: 29237
		public ETraceTracingImageType ImageResourceType;

		// Token: 0x04007236 RID: 29238
		public ITraceTracingGridBoard BoardConfig;

		// Token: 0x04007237 RID: 29239
		public int StepLimit;

		// Token: 0x04007238 RID: 29240
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITraceTracingMaxStepRewardRuleItem> MaxStepRewardRule;

		// Token: 0x04007239 RID: 29241
		public bool? RemainUiAfterCompletion;
	}
}
