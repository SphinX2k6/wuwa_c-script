using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002242 RID: 8770
	public class ITriggerDialogues_SetValue
	{
		// Token: 0x0400728F RID: 29327
		public EInteractEffectType Type;

		// Token: 0x04007290 RID: 29328
		public float? DelayTime;

		// Token: 0x04007291 RID: 29329
		public List<string> Talks;

		// Token: 0x04007292 RID: 29330
		[Nullable(2)]
		public IFocusObject FocusObject;
	}
}
