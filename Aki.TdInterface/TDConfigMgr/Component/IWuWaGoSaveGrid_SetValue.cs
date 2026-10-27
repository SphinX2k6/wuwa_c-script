using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000818 RID: 2072
	public class IWuWaGoSaveGrid_SetValue
	{
		// Token: 0x04001DC9 RID: 7625
		public EWuWaGoEntityType Type;

		// Token: 0x04001DCA RID: 7626
		[Nullable(1)]
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001DCB RID: 7627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IWuWaGoHintStepBase> HintSteps;
	}
}
