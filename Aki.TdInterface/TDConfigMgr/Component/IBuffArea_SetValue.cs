using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000200 RID: 512
	public class IBuffArea_SetValue
	{
		// Token: 0x04000928 RID: 2344
		public EEffectAreaType Type;

		// Token: 0x04000929 RID: 2345
		[Nullable(1)]
		public List<IBuffAreaStateConfig> BuffConfigs;
	}
}
