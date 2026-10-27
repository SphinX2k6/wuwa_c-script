using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A22 RID: 6690
	public class IExecuteTag_SetValue
	{
		// Token: 0x040058AE RID: 22702
		public EInteractEffectType Type;

		// Token: 0x040058AF RID: 22703
		public float? DelayTime;

		// Token: 0x040058B0 RID: 22704
		[Nullable(1)]
		public List<int> Tags;
	}
}
