using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000273 RID: 627
	public class ICircuitConnectLevelData_SetValue
	{
		// Token: 0x04000B11 RID: 2833
		public ICircuitConnectModeBase Mode;

		// Token: 0x04000B12 RID: 2834
		public float RotationSpeed;

		// Token: 0x04000B13 RID: 2835
		public float ConnectTolerance;

		// Token: 0x04000B14 RID: 2836
		public List<ICircuitConnectLinkageGroup> LinkageGroups;

		// Token: 0x04000B15 RID: 2837
		public List<ICircuitConnectLayout> Layout;
	}
}
