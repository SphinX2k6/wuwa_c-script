using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200615C RID: 24924
	[NullableContext(1)]
	[Nullable(0)]
	internal class ShopGridSortInfo : IShopGridSortInfo
	{
		// Token: 0x170091B4 RID: 37300
		// (get) Token: 0x0603EFEA RID: 258026 RVA: 0x00F37ADD File Offset: 0x00F35CDD
		// (set) Token: 0x0603EFEB RID: 258027 RVA: 0x00F37AE5 File Offset: 0x00F35CE5
		public IRoverlikeGameShopGridData Data { get; set; }

		// Token: 0x170091B5 RID: 37301
		// (get) Token: 0x0603EFEC RID: 258028 RVA: 0x00F37AEE File Offset: 0x00F35CEE
		// (set) Token: 0x0603EFED RID: 258029 RVA: 0x00F37AF6 File Offset: 0x00F35CF6
		public int OriginalIndex { get; set; }
	}
}
