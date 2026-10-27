using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002104 RID: 8452
	public class PlayBubble_SetValue
	{
		// Token: 0x04006F55 RID: 28501
		public int? EntityId;

		// Token: 0x04006F56 RID: 28502
		[Nullable(1)]
		public IBubbleIndex Flow;

		// Token: 0x04006F57 RID: 28503
		public bool? IsRangeFollowEntity;

		// Token: 0x04006F58 RID: 28504
		public bool? IsAudioOccludedByScene;

		// Token: 0x04006F59 RID: 28505
		[Nullable(2)]
		public IBubbleRangeCylinderConfig TriggerCylinderConfig;

		// Token: 0x04006F5A RID: 28506
		public bool? IsPlayMouthAnim;
	}
}
