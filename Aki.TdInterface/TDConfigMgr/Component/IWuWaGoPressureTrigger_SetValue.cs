using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B5 RID: 2229
	public class IWuWaGoPressureTrigger_SetValue
	{
		// Token: 0x04001FBE RID: 8126
		public EWuWaGoEntityType Type;

		// Token: 0x04001FBF RID: 8127
		public IWuWaGoGridLinkData LinkData;

		// Token: 0x04001FC0 RID: 8128
		public List<ActionInfo> EnterActionList;

		// Token: 0x04001FC1 RID: 8129
		public List<ActionInfo> ExitActionList;
	}
}
