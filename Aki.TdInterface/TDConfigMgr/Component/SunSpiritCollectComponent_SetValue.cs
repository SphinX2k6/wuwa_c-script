using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AC RID: 2220
	public class SunSpiritCollectComponent_SetValue
	{
		// Token: 0x040020A2 RID: 8354
		public bool? Disabled;

		// Token: 0x040020A3 RID: 8355
		public bool? EdIsLocked;

		// Token: 0x040020A4 RID: 8356
		public int AreaId;

		// Token: 0x040020A5 RID: 8357
		public float? SunSpiritScale;

		// Token: 0x040020A6 RID: 8358
		[Nullable(2)]
		public ISunSpiritPlayerBattleConfig PlayerBattleConfig;
	}
}
