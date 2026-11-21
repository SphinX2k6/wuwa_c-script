using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002096 RID: 8342
	public class IShowTalkCameraMotionPreset_SetValue
	{
		// Token: 0x0400694B RID: 26955
		public EShowTalkCameraMotionType Type;

		// Token: 0x0400694C RID: 26956
		public string Sequence;

		// Token: 0x0400694D RID: 26957
		[Nullable(2)]
		public IFlowCameraShake CamShake;
	}
}
