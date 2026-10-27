using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000D3 RID: 211
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementalWellComponent_SetValue
	{
		// Token: 0x0400049F RID: 1183
		public bool? Disabled;

		// Token: 0x040004A0 RID: 1184
		public bool? EdIsLocked;

		// Token: 0x040004A1 RID: 1185
		public EElementalWellEntryType WellType;

		// Token: 0x040004A2 RID: 1186
		[Nullable(1)]
		public IWellStreamingRenderConfig StreamingRenderConfig;

		// Token: 0x040004A3 RID: 1187
		[Nullable(1)]
		public IStreamingWaitConfig StreamWaitConfig;

		// Token: 0x040004A4 RID: 1188
		public string StreamingFinishedToState;

		// Token: 0x040004A5 RID: 1189
		public string LeaveRangeToState;

		// Token: 0x040004A6 RID: 1190
		public string PrefabBindPointKey;
	}
}
