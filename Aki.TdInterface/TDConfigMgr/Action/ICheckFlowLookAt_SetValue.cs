using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001891 RID: 6289
	public class ICheckFlowLookAt_SetValue
	{
		// Token: 0x04005513 RID: 21779
		public EOverrideLookAtType Type;

		// Token: 0x04005514 RID: 21780
		[Nullable(1)]
		public List<ICheckFlowLookAtConfig> CheckFlowLookAtConfigs;
	}
}
