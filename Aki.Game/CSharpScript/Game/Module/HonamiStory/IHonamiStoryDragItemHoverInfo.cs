using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005930 RID: 22832
	[NullableContext(1)]
	public interface IHonamiStoryDragItemHoverInfo
	{
		// Token: 0x17008AE6 RID: 35558
		// (get) Token: 0x06039FD9 RID: 237529
		// (set) Token: 0x06039FDA RID: 237530
		bool IsValid { get; set; }

		// Token: 0x17008AE7 RID: 35559
		// (get) Token: 0x06039FDB RID: 237531
		// (set) Token: 0x06039FDC RID: 237532
		int StartPosition { get; set; }

		// Token: 0x17008AE8 RID: 35560
		// (get) Token: 0x06039FDD RID: 237533
		// (set) Token: 0x06039FDE RID: 237534
		int EndPosition { get; set; }

		// Token: 0x17008AE9 RID: 35561
		// (get) Token: 0x06039FDF RID: 237535
		// (set) Token: 0x06039FE0 RID: 237536
		int Height { get; set; }

		// Token: 0x17008AEA RID: 35562
		// (get) Token: 0x06039FE1 RID: 237537
		// (set) Token: 0x06039FE2 RID: 237538
		int Width { get; set; }

		// Token: 0x17008AEB RID: 35563
		// (get) Token: 0x06039FE3 RID: 237539
		// (set) Token: 0x06039FE4 RID: 237540
		List<int> FillPosList { get; set; }
	}
}
