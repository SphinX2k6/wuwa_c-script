using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000190 RID: 400
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideLineCreatorComponent_SetValue
	{
		// Token: 0x04000795 RID: 1941
		public bool? Disabled;

		// Token: 0x04000796 RID: 1942
		public bool? EdIsLocked;

		// Token: 0x04000797 RID: 1943
		public IColorChangeStrategyOfRGB ColorChangeOption;

		// Token: 0x04000798 RID: 1944
		public int SplineEntityId;

		// Token: 0x04000799 RID: 1945
		public IGuideLineCreatorScanOption ScanOption;
	}
}
