using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002005 RID: 8197
	public class ITriggerVoiceDialogues_SetValue
	{
		// Token: 0x04006CA4 RID: 27812
		public EInteractEffectType Type;

		// Token: 0x04006CA5 RID: 27813
		public float? DelayTime;

		// Token: 0x04006CA6 RID: 27814
		[Nullable(1)]
		public PlayFlow Flow;

		// Token: 0x04006CA7 RID: 27815
		public bool? ShowTalker;
	}
}
