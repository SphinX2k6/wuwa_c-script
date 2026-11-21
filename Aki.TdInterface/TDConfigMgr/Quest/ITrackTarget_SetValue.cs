using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001307 RID: 4871
	public class ITrackTarget_SetValue
	{
		// Token: 0x04004191 RID: 16785
		public ITrackType TrackType;

		// Token: 0x04004192 RID: 16786
		public ETrackViewMode? TrackViewMode;

		// Token: 0x04004193 RID: 16787
		public float? Range;

		// Token: 0x04004194 RID: 16788
		public float? ViewRange;

		// Token: 0x04004195 RID: 16789
		[Nullable(2)]
		public IZaxisViewRange ZaxisViewRange;

		// Token: 0x04004196 RID: 16790
		public ETrackEffect? Effect;

		// Token: 0x04004197 RID: 16791
		[Nullable(2)]
		public ITrackEffectAutoChange EffectOption;
	}
}
