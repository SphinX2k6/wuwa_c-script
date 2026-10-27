using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000CF RID: 207
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalEffectComponent_SetValue
	{
		// Token: 0x0400048C RID: 1164
		public bool? Disabled;

		// Token: 0x0400048D RID: 1165
		public bool? EdIsLocked;

		// Token: 0x0400048E RID: 1166
		public IElementalMatchBase MatchConfig;

		// Token: 0x0400048F RID: 1167
		public IElementalRangeTypeBase Range;

		// Token: 0x04000490 RID: 1168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IElementalMatchActions> OnActiveEffectActions;

		// Token: 0x04000491 RID: 1169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IElementalMatchActions> OnLoseEffectActions;
	}
}
