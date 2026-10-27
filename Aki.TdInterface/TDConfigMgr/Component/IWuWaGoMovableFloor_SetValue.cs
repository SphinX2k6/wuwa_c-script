using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080E RID: 2062
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoMovableFloor_SetValue
	{
		// Token: 0x04001DA0 RID: 7584
		public EWuWaGoEntityType Type;

		// Token: 0x04001DA1 RID: 7585
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001DA2 RID: 7586
		[Nullable(2)]
		public IWuWaGoGridLinkData GearLinkData;

		// Token: 0x04001DA3 RID: 7587
		public List<IWuWaGoMovableGridStatePos> MoveData;
	}
}
