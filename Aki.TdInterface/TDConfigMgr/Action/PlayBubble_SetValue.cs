using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002365 RID: 9061
	public class PlayBubble_SetValue
	{
		// Token: 0x04007589 RID: 30089
		public int? EntityId;

		// Token: 0x0400758A RID: 30090
		public IBubbleIndex Flow;

		// Token: 0x0400758B RID: 30091
		public bool? IsRangeFollowEntity;

		// Token: 0x0400758C RID: 30092
		public bool? IsAudioOccludedByScene;

		// Token: 0x0400758D RID: 30093
		[Nullable(2)]
		public IBubbleRangeCylinderConfig TriggerCylinderConfig;

		// Token: 0x0400758E RID: 30094
		public bool? IsPlayMouthAnim;
	}
}
