using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000DB RID: 219
	public class ElementalWellComponent_SetValue
	{
		// Token: 0x040004C3 RID: 1219
		public bool? Disabled;

		// Token: 0x040004C4 RID: 1220
		public bool? EdIsLocked;

		// Token: 0x040004C5 RID: 1221
		public EElementalWellEntryType WellType;

		// Token: 0x040004C6 RID: 1222
		public IWellStreamingRenderConfig StreamingRenderConfig;

		// Token: 0x040004C7 RID: 1223
		public IStreamingWaitConfig StreamWaitConfig;

		// Token: 0x040004C8 RID: 1224
		[Nullable(2)]
		public string StreamingFinishedToState;

		// Token: 0x040004C9 RID: 1225
		[Nullable(2)]
		public string LeaveRangeToState;

		// Token: 0x040004CA RID: 1226
		[Nullable(2)]
		public string PrefabBindPointKey;
	}
}
