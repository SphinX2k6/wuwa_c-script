using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000D7 RID: 215
	public class ElementalEffectComponent_SetValue
	{
		// Token: 0x040004B0 RID: 1200
		public bool? Disabled;

		// Token: 0x040004B1 RID: 1201
		public bool? EdIsLocked;

		// Token: 0x040004B2 RID: 1202
		public IElementalMatchBase MatchConfig;

		// Token: 0x040004B3 RID: 1203
		public IElementalRangeTypeBase Range;

		// Token: 0x040004B4 RID: 1204
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IElementalMatchActions> OnActiveEffectActions;

		// Token: 0x040004B5 RID: 1205
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IElementalMatchActions> OnLoseEffectActions;
	}
}
