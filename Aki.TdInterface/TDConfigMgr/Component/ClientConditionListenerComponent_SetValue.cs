using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003F RID: 63
	public class ClientConditionListenerComponent_SetValue
	{
		// Token: 0x04000161 RID: 353
		public bool? Disabled;

		// Token: 0x04000162 RID: 354
		public bool? EdIsLocked;

		// Token: 0x04000163 RID: 355
		[Nullable(1)]
		public List<IClientConditionListener> Listeners;
	}
}
