using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200081C RID: 2076
	public class IWuWaGoStartGrid_SetValue
	{
		// Token: 0x04001DD6 RID: 7638
		public EWuWaGoEntityType Type;

		// Token: 0x04001DD7 RID: 7639
		[Nullable(1)]
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001DD8 RID: 7640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IWuWaGoHintStepBase> HintSteps;
	}
}
