using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A7 RID: 423
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideLineCreatorComponent_SetValue
	{
		// Token: 0x040007EB RID: 2027
		public bool? Disabled;

		// Token: 0x040007EC RID: 2028
		public bool? EdIsLocked;

		// Token: 0x040007ED RID: 2029
		public IColorChangeStrategyOfRGB ColorChangeOption;

		// Token: 0x040007EE RID: 2030
		public int SplineEntityId;

		// Token: 0x040007EF RID: 2031
		public IGuideLineCreatorScanOption ScanOption;
	}
}
