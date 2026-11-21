using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050DA RID: 20698
	[NullableContext(1)]
	[Nullable(0)]
	internal class ShopGridSortInfo : IShopGridSortInfo
	{
		// Token: 0x17006516 RID: 25878
		// (get) Token: 0x06033CAA RID: 212138 RVA: 0x00E7E9B1 File Offset: 0x00E7CBB1
		// (set) Token: 0x06033CAB RID: 212139 RVA: 0x00E7E9B9 File Offset: 0x00E7CBB9
		public IRoverlikeGameShopGridData Data { get; set; }

		// Token: 0x17006517 RID: 25879
		// (get) Token: 0x06033CAC RID: 212140 RVA: 0x00E7E9C2 File Offset: 0x00E7CBC2
		// (set) Token: 0x06033CAD RID: 212141 RVA: 0x00E7E9CA File Offset: 0x00E7CBCA
		public int OriginalIndex { get; set; }
	}
}
