using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006154 RID: 24916
	[NullableContext(1)]
	public interface IRoverlikeGameShopGroupData
	{
		// Token: 0x170091AC RID: 37292
		// (get) Token: 0x0603EFB4 RID: 257972
		// (set) Token: 0x0603EFB5 RID: 257973
		ERoverlikeGameShopItemType GroupType { get; set; }

		// Token: 0x170091AD RID: 37293
		// (get) Token: 0x0603EFB6 RID: 257974
		// (set) Token: 0x0603EFB7 RID: 257975
		string TitleTextKey { get; set; }

		// Token: 0x170091AE RID: 37294
		// (get) Token: 0x0603EFB8 RID: 257976
		// (set) Token: 0x0603EFB9 RID: 257977
		List<IRoverlikeGameShopGridData> Grids { get; set; }
	}
}
