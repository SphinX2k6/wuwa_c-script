using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000812 RID: 2066
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoPressureTrigger_SetValue
	{
		// Token: 0x04001DB2 RID: 7602
		public EWuWaGoEntityType Type;

		// Token: 0x04001DB3 RID: 7603
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001DB4 RID: 7604
		public List<ActionInfo> EnterActionList;

		// Token: 0x04001DB5 RID: 7605
		public List<ActionInfo> ExitActionList;
	}
}
