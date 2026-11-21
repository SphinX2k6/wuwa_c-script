using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043B4 RID: 17332
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardItemData : IRewardItemData
	{
		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x0602BCA1 RID: 179361 RVA: 0x00C4BAE7 File Offset: 0x00C49CE7
		// (set) Token: 0x0602BCA2 RID: 179362 RVA: 0x00C4BAEF File Offset: 0x00C49CEF
		public ItemConfig ItemInfo { get; set; }

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x0602BCA3 RID: 179363 RVA: 0x00C4BAF8 File Offset: 0x00C49CF8
		// (set) Token: 0x0602BCA4 RID: 179364 RVA: 0x00C4BB00 File Offset: 0x00C49D00
		public int Count { get; set; }
	}
}
