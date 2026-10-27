using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085A RID: 2138
	public class ProceduralMaterialComponent_SetValue
	{
		// Token: 0x04001F27 RID: 7975
		public bool? Disabled;

		// Token: 0x04001F28 RID: 7976
		public bool? EdIsLocked;

		// Token: 0x04001F29 RID: 7977
		[Nullable(1)]
		public List<ICustomPrimitiveDataConfig> ProceduralMaterialConfigs;
	}
}
