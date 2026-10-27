using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB7 RID: 7607
	public class IResetTeleControlEntity_SetValue
	{
		// Token: 0x040061CB RID: 25035
		public EResetEntityType Type;

		// Token: 0x040061CC RID: 25036
		[Nullable(1)]
		public List<int> EntityIds;
	}
}
