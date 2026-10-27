using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200615B RID: 24923
	[NullableContext(1)]
	internal interface IShopGridSortInfo
	{
		// Token: 0x170091B2 RID: 37298
		// (get) Token: 0x0603EFE6 RID: 258022
		// (set) Token: 0x0603EFE7 RID: 258023
		IRoverlikeGameShopGridData Data { get; set; }

		// Token: 0x170091B3 RID: 37299
		// (get) Token: 0x0603EFE8 RID: 258024
		// (set) Token: 0x0603EFE9 RID: 258025
		int OriginalIndex { get; set; }
	}
}
