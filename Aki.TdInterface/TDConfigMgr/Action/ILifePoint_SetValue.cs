using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D28 RID: 7464
	public class ILifePoint_SetValue
	{
		// Token: 0x040060AB RID: 24747
		public ESimpleGameplayType Type;

		// Token: 0x040060AC RID: 24748
		public ILifePointColorBoard ColorBoard;

		// Token: 0x040060AD RID: 24749
		public int StepLimit;

		// Token: 0x040060AE RID: 24750
		public string TidDesc;

		// Token: 0x040060AF RID: 24751
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ILifePointMaxStepRewardRuleItem> MaxStepRewardRule;

		// Token: 0x040060B0 RID: 24752
		public bool? CloseUiAfterCompletion;

		// Token: 0x040060B1 RID: 24753
		[Nullable(2)]
		public string EdTidDesc;
	}
}
