using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7B RID: 7035
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePoint_SetValue
	{
		// Token: 0x04005C12 RID: 23570
		public ESimpleGameplayType Type;

		// Token: 0x04005C13 RID: 23571
		public ILifePointColorBoard ColorBoard;

		// Token: 0x04005C14 RID: 23572
		public int StepLimit;

		// Token: 0x04005C15 RID: 23573
		public string TidDesc;

		// Token: 0x04005C16 RID: 23574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ILifePointMaxStepRewardRuleItem> MaxStepRewardRule;

		// Token: 0x04005C17 RID: 23575
		public bool? CloseUiAfterCompletion;

		// Token: 0x04005C18 RID: 23576
		[Nullable(2)]
		public string EdTidDesc;
	}
}
