using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C7A RID: 23674
	[NullableContext(1)]
	public interface IBattleUiHoverTipsD
	{
		// Token: 0x17008DC5 RID: 36293
		// (get) Token: 0x0603BD16 RID: 245014
		// (set) Token: 0x0603BD17 RID: 245015
		string TitleKey { get; set; }

		// Token: 0x17008DC6 RID: 36294
		// (get) Token: 0x0603BD18 RID: 245016
		// (set) Token: 0x0603BD19 RID: 245017
		FColor? TitleColor { get; set; }

		// Token: 0x17008DC7 RID: 36295
		// (get) Token: 0x0603BD1A RID: 245018
		// (set) Token: 0x0603BD1B RID: 245019
		[Nullable(2)]
		string SubTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008DC8 RID: 36296
		// (get) Token: 0x0603BD1C RID: 245020
		// (set) Token: 0x0603BD1D RID: 245021
		IMediumItemGridBase ItemInfo { get; set; }

		// Token: 0x17008DC9 RID: 36297
		// (get) Token: 0x0603BD1E RID: 245022
		// (set) Token: 0x0603BD1F RID: 245023
		List<IBattleUiHoverTipsDescInfo> DescInfoList { get; set; }

		// Token: 0x17008DCA RID: 36298
		// (get) Token: 0x0603BD20 RID: 245024
		// (set) Token: 0x0603BD21 RID: 245025
		[Nullable(2)]
		string DescTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
