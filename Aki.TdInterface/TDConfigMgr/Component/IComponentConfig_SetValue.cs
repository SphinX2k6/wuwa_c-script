using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200025D RID: 605
	[NullableContext(1)]
	[Nullable(0)]
	public class IComponentConfig_SetValue
	{
		// Token: 0x04000AB6 RID: 2742
		public List<EAction> BaseActions;

		// Token: 0x04000AB7 RID: 2743
		public string ActionsByComponent;
	}
}
