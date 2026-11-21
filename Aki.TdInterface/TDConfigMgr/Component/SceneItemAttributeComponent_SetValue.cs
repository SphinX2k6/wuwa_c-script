using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000931 RID: 2353
	public class SceneItemAttributeComponent_SetValue
	{
		// Token: 0x04002230 RID: 8752
		public bool? Disabled;

		// Token: 0x04002231 RID: 8753
		public bool? EdIsLocked;

		// Token: 0x04002232 RID: 8754
		public string AttributeType;

		// Token: 0x04002233 RID: 8755
		[Nullable(2)]
		public List<int> DefaultTags;
	}
}
