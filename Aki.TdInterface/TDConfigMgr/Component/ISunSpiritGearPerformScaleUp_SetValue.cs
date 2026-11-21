using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007DF RID: 2015
	public class ISunSpiritGearPerformScaleUp_SetValue
	{
		// Token: 0x04001CF4 RID: 7412
		public ESunSpiritGearPerformType Type;

		// Token: 0x04001CF5 RID: 7413
		public float Scale;

		// Token: 0x04001CF6 RID: 7414
		[Nullable(2)]
		public IScaleUpSpiritPerformConfig ScaleUpPerformConfig;
	}
}
