using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005931 RID: 22833
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryDragItemHoverInfo : IHonamiStoryDragItemHoverInfo
	{
		// Token: 0x17008AEC RID: 35564
		// (get) Token: 0x06039FE5 RID: 237541 RVA: 0x00DCA47A File Offset: 0x00DC867A
		// (set) Token: 0x06039FE6 RID: 237542 RVA: 0x00DCA482 File Offset: 0x00DC8682
		public bool IsValid { get; set; }

		// Token: 0x17008AED RID: 35565
		// (get) Token: 0x06039FE7 RID: 237543 RVA: 0x00DCA48B File Offset: 0x00DC868B
		// (set) Token: 0x06039FE8 RID: 237544 RVA: 0x00DCA493 File Offset: 0x00DC8693
		public int StartPosition { get; set; }

		// Token: 0x17008AEE RID: 35566
		// (get) Token: 0x06039FE9 RID: 237545 RVA: 0x00DCA49C File Offset: 0x00DC869C
		// (set) Token: 0x06039FEA RID: 237546 RVA: 0x00DCA4A4 File Offset: 0x00DC86A4
		public int EndPosition { get; set; }

		// Token: 0x17008AEF RID: 35567
		// (get) Token: 0x06039FEB RID: 237547 RVA: 0x00DCA4AD File Offset: 0x00DC86AD
		// (set) Token: 0x06039FEC RID: 237548 RVA: 0x00DCA4B5 File Offset: 0x00DC86B5
		public int Height { get; set; }

		// Token: 0x17008AF0 RID: 35568
		// (get) Token: 0x06039FED RID: 237549 RVA: 0x00DCA4BE File Offset: 0x00DC86BE
		// (set) Token: 0x06039FEE RID: 237550 RVA: 0x00DCA4C6 File Offset: 0x00DC86C6
		public int Width { get; set; }

		// Token: 0x17008AF1 RID: 35569
		// (get) Token: 0x06039FEF RID: 237551 RVA: 0x00DCA4CF File Offset: 0x00DC86CF
		// (set) Token: 0x06039FF0 RID: 237552 RVA: 0x00DCA4D7 File Offset: 0x00DC86D7
		public List<int> FillPosList { get; set; } = new List<int>();
	}
}
