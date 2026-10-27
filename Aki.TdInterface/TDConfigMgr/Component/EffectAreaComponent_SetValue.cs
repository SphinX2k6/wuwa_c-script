using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000A9 RID: 169
	public class EffectAreaComponent_SetValue
	{
		// Token: 0x040003EE RID: 1006
		public bool? Disabled;

		// Token: 0x040003EF RID: 1007
		public bool? EdIsLocked;

		// Token: 0x040003F0 RID: 1008
		[Nullable(1)]
		public IBuffArea Config;
	}
}
