using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000276 RID: 630
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceInitiator_SetValue
	{
		// Token: 0x04000B1D RID: 2845
		public string ActiveState;

		// Token: 0x04000B1E RID: 2846
		public List<int> Paths;

		// Token: 0x04000B1F RID: 2847
		public int TargetEntity;

		// Token: 0x04000B20 RID: 2848
		public float AdvanceSpeed;

		// Token: 0x04000B21 RID: 2849
		public EConnectorPathAdvanceVisualType VisualType;

		// Token: 0x04000B22 RID: 2850
		[Nullable(2)]
		public IConnectorPathAdvanceVasePlantVisual VisualConfig;

		// Token: 0x04000B23 RID: 2851
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDynamicEntityMatch> KeepConditions;
	}
}
