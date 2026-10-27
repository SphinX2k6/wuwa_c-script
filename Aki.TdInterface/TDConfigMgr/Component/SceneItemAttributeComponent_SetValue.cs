using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088E RID: 2190
	public class SceneItemAttributeComponent_SetValue
	{
		// Token: 0x0400201E RID: 8222
		public bool? Disabled;

		// Token: 0x0400201F RID: 8223
		public bool? EdIsLocked;

		// Token: 0x04002020 RID: 8224
		[Nullable(1)]
		public string AttributeType;

		// Token: 0x04002021 RID: 8225
		[Nullable(2)]
		public List<int> DefaultTags;
	}
}
