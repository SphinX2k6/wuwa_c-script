using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005949 RID: 22857
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryAttrData : IHonamiStoryAttrData
	{
		// Token: 0x17008B0D RID: 35597
		// (get) Token: 0x0603A02D RID: 237613 RVA: 0x00DCA5E1 File Offset: 0x00DC87E1
		// (set) Token: 0x0603A02E RID: 237614 RVA: 0x00DCA5E9 File Offset: 0x00DC87E9
		public string Name { get; set; } = string.Empty;

		// Token: 0x17008B0E RID: 35598
		// (get) Token: 0x0603A02F RID: 237615 RVA: 0x00DCA5F2 File Offset: 0x00DC87F2
		// (set) Token: 0x0603A030 RID: 237616 RVA: 0x00DCA5FA File Offset: 0x00DC87FA
		public string IconPath { get; set; } = string.Empty;

		// Token: 0x17008B0F RID: 35599
		// (get) Token: 0x0603A031 RID: 237617 RVA: 0x00DCA603 File Offset: 0x00DC8803
		// (set) Token: 0x0603A032 RID: 237618 RVA: 0x00DCA60B File Offset: 0x00DC880B
		public int OldValue { get; set; }

		// Token: 0x17008B10 RID: 35600
		// (get) Token: 0x0603A033 RID: 237619 RVA: 0x00DCA614 File Offset: 0x00DC8814
		// (set) Token: 0x0603A034 RID: 237620 RVA: 0x00DCA61C File Offset: 0x00DC881C
		public int NewValue { get; set; }

		// Token: 0x17008B11 RID: 35601
		// (get) Token: 0x0603A035 RID: 237621 RVA: 0x00DCA625 File Offset: 0x00DC8825
		// (set) Token: 0x0603A036 RID: 237622 RVA: 0x00DCA62D File Offset: 0x00DC882D
		public bool IsPercent { get; set; }
	}
}
