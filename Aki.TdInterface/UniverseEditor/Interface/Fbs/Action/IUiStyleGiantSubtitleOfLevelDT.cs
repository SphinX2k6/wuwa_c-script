using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA8 RID: 31912
	public class IUiStyleGiantSubtitleOfLevelDT
	{
		// Token: 0x1700EEE4 RID: 61156
		// (get) Token: 0x06039907 RID: 235783 RVA: 0x007C4B4C File Offset: 0x007C2D4C
		// (set) Token: 0x06039908 RID: 235784 RVA: 0x007C4B54 File Offset: 0x007C2D54
		public EUiStyleTypeOfLevelD Type { get; set; }

		// Token: 0x1700EEE5 RID: 61157
		// (get) Token: 0x06039909 RID: 235785 RVA: 0x007C4B5D File Offset: 0x007C2D5D
		// (set) Token: 0x0603990A RID: 235786 RVA: 0x007C4B65 File Offset: 0x007C2D65
		public EGiantSubtitleStyle Style { get; set; }

		// Token: 0x0603990B RID: 235787 RVA: 0x007C4B6E File Offset: 0x007C2D6E
		public IUiStyleGiantSubtitleOfLevelDT()
		{
			this.Type = EUiStyleTypeOfLevelD.GiantSubtitle;
			this.Style = EGiantSubtitleStyle.Neutral;
		}
	}
}
