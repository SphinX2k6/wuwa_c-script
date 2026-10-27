using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02006DE0 RID: 28128
	[NullableContext(1)]
	public interface IItemInspectVisiblePointData
	{
		// Token: 0x170099D3 RID: 39379
		// (get) Token: 0x060449D2 RID: 281042
		// (set) Token: 0x060449D3 RID: 281043
		int TagId { get; set; }

		// Token: 0x170099D4 RID: 39380
		// (get) Token: 0x060449D4 RID: 281044
		// (set) Token: 0x060449D5 RID: 281045
		Vector Location { get; set; }

		// Token: 0x170099D5 RID: 39381
		// (get) Token: 0x060449D6 RID: 281046
		// (set) Token: 0x060449D7 RID: 281047
		bool IsChecked { get; set; }
	}
}
