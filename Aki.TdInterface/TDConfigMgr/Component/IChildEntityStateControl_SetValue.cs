using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000265 RID: 613
	public class IChildEntityStateControl_SetValue
	{
		// Token: 0x04000AD3 RID: 2771
		public ETemplateEntityGroupType GroupType;

		// Token: 0x04000AD4 RID: 2772
		public string InitState;

		// Token: 0x04000AD5 RID: 2773
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IChildStateChangedConfig> OnChildStateChangedConfigs;
	}
}
