using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C5A RID: 19546
	[NullableContext(1)]
	public interface IBattleUiHoverTipsD
	{
		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x06030C64 RID: 199780
		// (set) Token: 0x06030C65 RID: 199781
		string TitleKey { get; set; }

		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x06030C66 RID: 199782
		// (set) Token: 0x06030C67 RID: 199783
		FColor? TitleColor { get; set; }

		// Token: 0x17006199 RID: 24985
		// (get) Token: 0x06030C68 RID: 199784
		// (set) Token: 0x06030C69 RID: 199785
		[Nullable(2)]
		string SubTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700619A RID: 24986
		// (get) Token: 0x06030C6A RID: 199786
		// (set) Token: 0x06030C6B RID: 199787
		IMediumItemGridBase ItemInfo { get; set; }

		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x06030C6C RID: 199788
		// (set) Token: 0x06030C6D RID: 199789
		List<IBattleUiHoverTipsDescInfo> DescInfoList { get; set; }

		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x06030C6E RID: 199790
		// (set) Token: 0x06030C6F RID: 199791
		[Nullable(2)]
		string DescTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
