using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BF RID: 2239
	public class IWuWaGoStartGrid_SetValue
	{
		// Token: 0x04001FE2 RID: 8162
		public EWuWaGoEntityType Type;

		// Token: 0x04001FE3 RID: 8163
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001FE4 RID: 8164
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IWuWaGoHintStepBase> HintSteps;
	}
}
