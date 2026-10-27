using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011CB RID: 4555
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackTarget_SetValue
	{
		// Token: 0x04003E23 RID: 15907
		[Nullable(1)]
		public ITrackType TrackType;

		// Token: 0x04003E24 RID: 15908
		public ETrackViewMode? TrackViewMode;

		// Token: 0x04003E25 RID: 15909
		public float? Range;

		// Token: 0x04003E26 RID: 15910
		public float? ViewRange;

		// Token: 0x04003E27 RID: 15911
		public IZaxisViewRange ZaxisViewRange;

		// Token: 0x04003E28 RID: 15912
		public ETrackEffect? Effect;

		// Token: 0x04003E29 RID: 15913
		public ITrackEffectAutoChange EffectOption;
	}
}
