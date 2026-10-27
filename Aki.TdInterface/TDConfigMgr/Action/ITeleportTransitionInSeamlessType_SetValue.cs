using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA5 RID: 8101
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionInSeamlessType_SetValue
	{
		// Token: 0x04006B93 RID: 27539
		public ETeleportTransitionType Type;

		// Token: 0x04006B94 RID: 27540
		[Nullable(1)]
		public string EffectDaPath;

		// Token: 0x04006B95 RID: 27541
		public float LeastTime;

		// Token: 0x04006B96 RID: 27542
		public float EffectExpandTime;

		// Token: 0x04006B97 RID: 27543
		public float EffectCollapseTime;

		// Token: 0x04006B98 RID: 27544
		public string SceneEffectDaPath;

		// Token: 0x04006B99 RID: 27545
		public string TransitionWeatherDaPath;

		// Token: 0x04006B9A RID: 27546
		public IFloorSettings FloorSettings;

		// Token: 0x04006B9B RID: 27547
		public bool? IsTeleportInPlace;

		// Token: 0x04006B9C RID: 27548
		public List<EKeepMovementState> KeepMovementStates;

		// Token: 0x04006B9D RID: 27549
		public ISeamlessTeleportFinishConfig SeamlessTeleportFinishConfig;

		// Token: 0x04006B9E RID: 27550
		public bool? IsNormalStreamingLoad;
	}
}
