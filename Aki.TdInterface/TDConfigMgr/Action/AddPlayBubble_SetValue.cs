using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001496 RID: 5270
	[NullableContext(1)]
	[Nullable(0)]
	public class AddPlayBubble_SetValue
	{
		// Token: 0x040045B5 RID: 17845
		public List<int> EntityIds;

		// Token: 0x040045B6 RID: 17846
		public float? EnterRadius;

		// Token: 0x040045B7 RID: 17847
		public float? LeaveRadius;

		// Token: 0x040045B8 RID: 17848
		public bool? IsRangeFollowEntity;

		// Token: 0x040045B9 RID: 17849
		public IBubbleIndex Flow;

		// Token: 0x040045BA RID: 17850
		public int? WaitTime;

		// Token: 0x040045BB RID: 17851
		public bool? RedDot;

		// Token: 0x040045BC RID: 17852
		public bool? IsAudioOccludedByScene;

		// Token: 0x040045BD RID: 17853
		[Nullable(2)]
		public IBubbleRangeCylinderConfig TriggerCylinderConfig;

		// Token: 0x040045BE RID: 17854
		public bool? IsPlayMouthAnim;
	}
}
