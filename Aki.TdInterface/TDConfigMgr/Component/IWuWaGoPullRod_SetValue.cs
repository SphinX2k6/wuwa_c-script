using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000814 RID: 2068
	public class IWuWaGoPullRod_SetValue
	{
		// Token: 0x04001DBA RID: 7610
		public EWuWaGoEntityType Type;

		// Token: 0x04001DBB RID: 7611
		[Nullable(1)]
		public List<IWuWaGoInteractStateAction> InteractConfig;
	}
}
