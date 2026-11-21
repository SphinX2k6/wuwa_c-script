using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C5C RID: 19548
	[NullableContext(1)]
	public interface IBattleUiHoverTipsDescInfo
	{
		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x06030C7D RID: 199805
		// (set) Token: 0x06030C7E RID: 199806
		string DescKey { get; set; }

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x06030C7F RID: 199807
		// (set) Token: 0x06030C80 RID: 199808
		bool? DescUseChangeColor { get; set; }

		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x06030C81 RID: 199809
		// (set) Token: 0x06030C82 RID: 199810
		[Nullable(2)]
		string StateTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x06030C83 RID: 199811
		// (set) Token: 0x06030C84 RID: 199812
		bool? IsUnlock { get; set; }

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x06030C85 RID: 199813
		// (set) Token: 0x06030C86 RID: 199814
		bool? IsShowState { get; set; }
	}
}
