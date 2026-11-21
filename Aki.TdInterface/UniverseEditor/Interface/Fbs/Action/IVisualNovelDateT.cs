using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D6E RID: 32110
	public class IVisualNovelDateT
	{
		// Token: 0x1700F047 RID: 61511
		// (get) Token: 0x06039F86 RID: 237446 RVA: 0x007D1194 File Offset: 0x007CF394
		// (set) Token: 0x06039F87 RID: 237447 RVA: 0x007D119C File Offset: 0x007CF39C
		public int Month { get; set; }

		// Token: 0x1700F048 RID: 61512
		// (get) Token: 0x06039F88 RID: 237448 RVA: 0x007D11A5 File Offset: 0x007CF3A5
		// (set) Token: 0x06039F89 RID: 237449 RVA: 0x007D11AD File Offset: 0x007CF3AD
		public int Day { get; set; }

		// Token: 0x06039F8A RID: 237450 RVA: 0x007D11B6 File Offset: 0x007CF3B6
		public IVisualNovelDateT()
		{
			this.Month = 0;
			this.Day = 0;
		}
	}
}
