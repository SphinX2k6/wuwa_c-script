using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B1 RID: 2225
	public class IWuWaGoMovableFloor_SetValue
	{
		// Token: 0x04001FAC RID: 8108
		public EWuWaGoEntityType Type;

		// Token: 0x04001FAD RID: 8109
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001FAE RID: 8110
		[Nullable(2)]
		public IWuWaGoGridLinkData GearLinkData;

		// Token: 0x04001FAF RID: 8111
		public List<IWuWaGoMovableGridStatePos> MoveData;
	}
}
