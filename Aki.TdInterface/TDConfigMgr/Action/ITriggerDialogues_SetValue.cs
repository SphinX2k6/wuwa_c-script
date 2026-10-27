using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFB RID: 8187
	public class ITriggerDialogues_SetValue
	{
		// Token: 0x04006C8D RID: 27789
		public EInteractEffectType Type;

		// Token: 0x04006C8E RID: 27790
		public float? DelayTime;

		// Token: 0x04006C8F RID: 27791
		[Nullable(1)]
		public List<string> Talks;

		// Token: 0x04006C90 RID: 27792
		[Nullable(2)]
		public IFocusObject FocusObject;
	}
}
