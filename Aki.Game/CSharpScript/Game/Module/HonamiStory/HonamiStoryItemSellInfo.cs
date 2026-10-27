using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005940 RID: 22848
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryItemSellInfo : IHonamiStoryItemSellInfo
	{
		// Token: 0x17008AFC RID: 35580
		// (get) Token: 0x0603A008 RID: 237576 RVA: 0x00DCA552 File Offset: 0x00DC8752
		// (set) Token: 0x0603A009 RID: 237577 RVA: 0x00DCA55A File Offset: 0x00DC875A
		public HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17008AFD RID: 35581
		// (get) Token: 0x0603A00A RID: 237578 RVA: 0x00DCA563 File Offset: 0x00DC8763
		// (set) Token: 0x0603A00B RID: 237579 RVA: 0x00DCA56B File Offset: 0x00DC876B
		public EHonamiStoryBackpack BackpackType { get; set; }
	}
}
