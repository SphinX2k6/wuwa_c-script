using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E61 RID: 7777
	public class IShowTalkCameraMotionPreset_SetValue
	{
		// Token: 0x04006367 RID: 25447
		public EShowTalkCameraMotionType Type;

		// Token: 0x04006368 RID: 25448
		[Nullable(1)]
		public string Sequence;

		// Token: 0x04006369 RID: 25449
		[Nullable(2)]
		public IFlowCameraShake CamShake;
	}
}
