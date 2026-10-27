using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B04 RID: 6916
	public class IHideSpecifyDataLayers_SetValue
	{
		// Token: 0x04005ADD RID: 23261
		public EHideType Type;

		// Token: 0x04005ADE RID: 23262
		[Nullable(1)]
		public List<int> DataLayers;
	}
}
