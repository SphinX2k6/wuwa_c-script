using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000168 RID: 360
	public class ExhibitComponent_SetValue
	{
		// Token: 0x040006D2 RID: 1746
		public bool? Disabled;

		// Token: 0x040006D3 RID: 1747
		public bool? EdIsLocked;

		// Token: 0x040006D4 RID: 1748
		[Nullable(1)]
		public IExhibitItemType ExhibitConfig;
	}
}
