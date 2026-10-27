using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B2 RID: 29874
	public class IUiStyleGiantSubtitleOfLevelDT
	{
		// Token: 0x1700E2C0 RID: 58048
		// (get) Token: 0x060364FE RID: 222462 RVA: 0x00761AC0 File Offset: 0x0075FCC0
		// (set) Token: 0x060364FF RID: 222463 RVA: 0x00761AC8 File Offset: 0x0075FCC8
		public EUiStyleTypeOfLevelD Type { get; set; }

		// Token: 0x1700E2C1 RID: 58049
		// (get) Token: 0x06036500 RID: 222464 RVA: 0x00761AD1 File Offset: 0x0075FCD1
		// (set) Token: 0x06036501 RID: 222465 RVA: 0x00761AD9 File Offset: 0x0075FCD9
		public EGiantSubtitleStyle Style { get; set; }

		// Token: 0x06036502 RID: 222466 RVA: 0x00761AE2 File Offset: 0x0075FCE2
		public IUiStyleGiantSubtitleOfLevelDT()
		{
			this.Type = EUiStyleTypeOfLevelD.GiantSubtitle;
			this.Style = EGiantSubtitleStyle.Neutral;
		}
	}
}
