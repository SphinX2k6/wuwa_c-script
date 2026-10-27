using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B5B RID: 7003
	public class IItemCellIndependentDeliverType_SetValue
	{
		// Token: 0x04005BB9 RID: 23481
		public EDeliverType Type;

		// Token: 0x04005BBA RID: 23482
		[Nullable(1)]
		public List<IDeliverItem> DeliverItem;
	}
}
