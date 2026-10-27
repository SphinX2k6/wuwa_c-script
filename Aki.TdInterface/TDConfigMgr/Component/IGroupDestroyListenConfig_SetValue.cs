using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FD RID: 1021
	public class IGroupDestroyListenConfig_SetValue
	{
		// Token: 0x0400102A RID: 4138
		public ETemplateEntityGroupType GroupType;

		// Token: 0x0400102B RID: 4139
		[Nullable(1)]
		public List<ActionInfo> OnTriggerActions;

		// Token: 0x0400102C RID: 4140
		[Nullable(2)]
		public IChangeTemplateInstanceStateConfig ChangeInstanceStateConfig;
	}
}
