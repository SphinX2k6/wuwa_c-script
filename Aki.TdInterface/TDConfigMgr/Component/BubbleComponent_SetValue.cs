using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000033 RID: 51
	public class BubbleComponent_SetValue
	{
		// Token: 0x0400012E RID: 302
		public bool? Disabled;

		// Token: 0x0400012F RID: 303
		public bool? EdIsLocked;

		// Token: 0x04000130 RID: 304
		public List<int> NpcIds;

		// Token: 0x04000131 RID: 305
		public float EnterRange;

		// Token: 0x04000132 RID: 306
		public float LeaveRange;

		// Token: 0x04000133 RID: 307
		public bool? IsRangeFollowEntity;

		// Token: 0x04000134 RID: 308
		public List<IConditionBubbleData> Flows;

		// Token: 0x04000135 RID: 309
		public int? TimberId;

		// Token: 0x04000136 RID: 310
		public float? Scale;

		// Token: 0x04000137 RID: 311
		public bool? IsAudioOccludedByScene;

		// Token: 0x04000138 RID: 312
		[Nullable(2)]
		public IBubbleRangeCylinderConfig TriggerCylinderConfig;

		// Token: 0x04000139 RID: 313
		public bool? IsPlayMouthAnim;
	}
}
