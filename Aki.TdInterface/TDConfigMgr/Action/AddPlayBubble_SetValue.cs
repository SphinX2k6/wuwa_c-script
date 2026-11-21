using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015EF RID: 5615
	public class AddPlayBubble_SetValue
	{
		// Token: 0x04004950 RID: 18768
		public List<int> EntityIds;

		// Token: 0x04004951 RID: 18769
		public float? EnterRadius;

		// Token: 0x04004952 RID: 18770
		public float? LeaveRadius;

		// Token: 0x04004953 RID: 18771
		public bool? IsRangeFollowEntity;

		// Token: 0x04004954 RID: 18772
		public IBubbleIndex Flow;

		// Token: 0x04004955 RID: 18773
		public int? WaitTime;

		// Token: 0x04004956 RID: 18774
		public bool? RedDot;

		// Token: 0x04004957 RID: 18775
		public bool? IsAudioOccludedByScene;

		// Token: 0x04004958 RID: 18776
		[Nullable(2)]
		public IBubbleRangeCylinderConfig TriggerCylinderConfig;

		// Token: 0x04004959 RID: 18777
		public bool? IsPlayMouthAnim;
	}
}
