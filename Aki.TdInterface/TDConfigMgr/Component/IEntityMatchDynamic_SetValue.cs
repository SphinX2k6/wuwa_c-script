using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032A RID: 810
	public class IEntityMatchDynamic_SetValue
	{
		// Token: 0x04000D82 RID: 3458
		public EEntityMatchType Type;

		// Token: 0x04000D83 RID: 3459
		[Nullable(1)]
		public List<IDynamicEntityMatch> MatchEntity;
	}
}
