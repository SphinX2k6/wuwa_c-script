using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094F RID: 2383
	public class SunSpiritCollectComponent_SetValue
	{
		// Token: 0x040022B4 RID: 8884
		public bool? Disabled;

		// Token: 0x040022B5 RID: 8885
		public bool? EdIsLocked;

		// Token: 0x040022B6 RID: 8886
		public int AreaId;

		// Token: 0x040022B7 RID: 8887
		public float? SunSpiritScale;

		// Token: 0x040022B8 RID: 8888
		[Nullable(2)]
		public ISunSpiritPlayerBattleConfig PlayerBattleConfig;
	}
}
