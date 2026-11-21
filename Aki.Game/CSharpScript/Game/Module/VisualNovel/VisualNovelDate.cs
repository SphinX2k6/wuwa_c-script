using System;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037AD RID: 14253
	public readonly struct VisualNovelDate
	{
		// Token: 0x17004C42 RID: 19522
		// (get) Token: 0x06025181 RID: 151937 RVA: 0x00A77B81 File Offset: 0x00A75D81
		public int Month { get; }

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x06025182 RID: 151938 RVA: 0x00A77B89 File Offset: 0x00A75D89
		public int Day { get; }

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x06025183 RID: 151939 RVA: 0x00A77B91 File Offset: 0x00A75D91
		public int PeriodId { get; }

		// Token: 0x06025184 RID: 151940 RVA: 0x00A77B99 File Offset: 0x00A75D99
		public VisualNovelDate(int month, int day, int periodId)
		{
			this.Month = month;
			this.Day = day;
			this.PeriodId = periodId;
		}
	}
}
