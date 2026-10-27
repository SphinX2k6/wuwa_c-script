using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200029C RID: 668
	public class ICustomPrimitiveDataConfig_SetValue
	{
		// Token: 0x04000BB0 RID: 2992
		public EProceduralMaterialType Type;

		// Token: 0x04000BB1 RID: 2993
		[Nullable(1)]
		public List<ICustomPrimitiveMapping> PrimitiveConfigs;

		// Token: 0x04000BB2 RID: 2994
		public bool? IsChildEffective;
	}
}
