using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB1 RID: 7089
	public class ILookAtBubbleEntityConfig_SetValue
	{
		// Token: 0x04005CA2 RID: 23714
		public int BubbleEntity;

		// Token: 0x04005CA3 RID: 23715
		[Nullable(1)]
		public List<int> RangeEntities;

		// Token: 0x04005CA4 RID: 23716
		[Nullable(2)]
		public IEntityLookAtPerform EntityLookAtPerform;
	}
}
