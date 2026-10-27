using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023E RID: 574
	public class IChildEntityStateControl_SetValue
	{
		// Token: 0x04000A49 RID: 2633
		public ETemplateEntityGroupType GroupType;

		// Token: 0x04000A4A RID: 2634
		[Nullable(1)]
		public string InitState;

		// Token: 0x04000A4B RID: 2635
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IChildStateChangedConfig> OnChildStateChangedConfigs;
	}
}
