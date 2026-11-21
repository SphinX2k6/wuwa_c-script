using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B9 RID: 697
	public class IConnectorPathAdvanceInitiator_SetValue
	{
		// Token: 0x04000BFE RID: 3070
		public string ActiveState;

		// Token: 0x04000BFF RID: 3071
		public List<int> Paths;

		// Token: 0x04000C00 RID: 3072
		public int TargetEntity;

		// Token: 0x04000C01 RID: 3073
		public float AdvanceSpeed;

		// Token: 0x04000C02 RID: 3074
		public EConnectorPathAdvanceVisualType VisualType;

		// Token: 0x04000C03 RID: 3075
		[Nullable(2)]
		public IConnectorPathAdvanceVasePlantVisual VisualConfig;

		// Token: 0x04000C04 RID: 3076
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDynamicEntityMatch> KeepConditions;
	}
}
