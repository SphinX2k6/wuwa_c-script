using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E8 RID: 8680
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionInSeamlessType_SetValue
	{
		// Token: 0x0400718E RID: 29070
		public ETeleportTransitionType Type;

		// Token: 0x0400718F RID: 29071
		[Nullable(0)]
		public string EffectDaPath;

		// Token: 0x04007190 RID: 29072
		public float LeastTime;

		// Token: 0x04007191 RID: 29073
		public float EffectExpandTime;

		// Token: 0x04007192 RID: 29074
		public float EffectCollapseTime;

		// Token: 0x04007193 RID: 29075
		public string SceneEffectDaPath;

		// Token: 0x04007194 RID: 29076
		public string TransitionWeatherDaPath;

		// Token: 0x04007195 RID: 29077
		public IFloorSettings FloorSettings;

		// Token: 0x04007196 RID: 29078
		public bool? IsTeleportInPlace;

		// Token: 0x04007197 RID: 29079
		public List<EKeepMovementState> KeepMovementStates;

		// Token: 0x04007198 RID: 29080
		public ISeamlessTeleportFinishConfig SeamlessTeleportFinishConfig;

		// Token: 0x04007199 RID: 29081
		public bool? IsNormalStreamingLoad;
	}
}
