using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB5 RID: 7093
	public class ILookAtTarget_SetValue
	{
		// Token: 0x04005CAD RID: 23725
		public EDefaultLookAtType Type;

		// Token: 0x04005CAE RID: 23726
		[Nullable(1)]
		public List<INpcLookAtConfig> LookAtConfigs;
	}
}
