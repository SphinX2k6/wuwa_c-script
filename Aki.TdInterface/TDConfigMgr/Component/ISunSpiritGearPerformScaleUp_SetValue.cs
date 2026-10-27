using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200073E RID: 1854
	public class ISunSpiritGearPerformScaleUp_SetValue
	{
		// Token: 0x04001AEF RID: 6895
		public ESunSpiritGearPerformType Type;

		// Token: 0x04001AF0 RID: 6896
		public float Scale;

		// Token: 0x04001AF1 RID: 6897
		[Nullable(2)]
		public IScaleUpSpiritPerformConfig ScaleUpPerformConfig;
	}
}
