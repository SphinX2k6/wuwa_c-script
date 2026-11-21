using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D9 RID: 20697
	[NullableContext(1)]
	internal interface IShopGridSortInfo
	{
		// Token: 0x17006514 RID: 25876
		// (get) Token: 0x06033CA6 RID: 212134
		// (set) Token: 0x06033CA7 RID: 212135
		IRoverlikeGameShopGridData Data { get; set; }

		// Token: 0x17006515 RID: 25877
		// (get) Token: 0x06033CA8 RID: 212136
		// (set) Token: 0x06033CA9 RID: 212137
		int OriginalIndex { get; set; }
	}
}
