using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000456 RID: 1110
	public class IGroupDestroyListenConfig_SetValue
	{
		// Token: 0x0400114C RID: 4428
		public ETemplateEntityGroupType GroupType;

		// Token: 0x0400114D RID: 4429
		public List<ActionInfo> OnTriggerActions;

		// Token: 0x0400114E RID: 4430
		[Nullable(2)]
		public IChangeTemplateInstanceStateConfig ChangeInstanceStateConfig;
	}
}
