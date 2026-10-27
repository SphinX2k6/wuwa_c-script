using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5D RID: 27997
	public class IPlotModeUiStyleLevelDT
	{
		// Token: 0x1700D0C7 RID: 53447
		// (get) Token: 0x060316F0 RID: 202480 RVA: 0x006B3E73 File Offset: 0x006B2073
		// (set) Token: 0x060316F1 RID: 202481 RVA: 0x006B3E7B File Offset: 0x006B207B
		public EPlotModeUiStyleType Type { get; set; }

		// Token: 0x1700D0C8 RID: 53448
		// (get) Token: 0x060316F2 RID: 202482 RVA: 0x006B3E84 File Offset: 0x006B2084
		// (set) Token: 0x060316F3 RID: 202483 RVA: 0x006B3E8C File Offset: 0x006B208C
		public TUiStyleOfLevelDUnion UiStyle { get; set; }

		// Token: 0x060316F4 RID: 202484 RVA: 0x006B3E95 File Offset: 0x006B2095
		public IPlotModeUiStyleLevelDT()
		{
			this.Type = EPlotModeUiStyleType.LevelD;
			this.UiStyle = null;
		}
	}
}
