using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BB RID: 2235
	public class IWuWaGoSaveGrid_SetValue
	{
		// Token: 0x04001FD5 RID: 8149
		public EWuWaGoEntityType Type;

		// Token: 0x04001FD6 RID: 8150
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001FD7 RID: 8151
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IWuWaGoHintStepBase> HintSteps;
	}
}
