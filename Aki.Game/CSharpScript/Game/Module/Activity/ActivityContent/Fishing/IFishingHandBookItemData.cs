using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005581 RID: 21889
	[NullableContext(1)]
	public interface IFishingHandBookItemData
	{
		// Token: 0x17006950 RID: 26960
		// (get) Token: 0x060363FA RID: 222202
		// (set) Token: 0x060363FB RID: 222203
		int Id { get; set; }

		// Token: 0x17006951 RID: 26961
		// (get) Token: 0x060363FC RID: 222204
		// (set) Token: 0x060363FD RID: 222205
		int Type { get; set; }

		// Token: 0x17006952 RID: 26962
		// (get) Token: 0x060363FE RID: 222206
		// (set) Token: 0x060363FF RID: 222207
		int Time { get; set; }

		// Token: 0x17006953 RID: 26963
		// (get) Token: 0x06036400 RID: 222208
		// (set) Token: 0x06036401 RID: 222209
		List<int> Tech { get; set; }

		// Token: 0x17006954 RID: 26964
		// (get) Token: 0x06036402 RID: 222210
		// (set) Token: 0x06036403 RID: 222211
		List<int> Area { get; set; }

		// Token: 0x17006955 RID: 26965
		// (get) Token: 0x06036404 RID: 222212
		// (set) Token: 0x06036405 RID: 222213
		int HandBookId { get; set; }
	}
}
