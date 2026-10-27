using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B5 RID: 29877
	public class IUiStylePlayPianoOfLevelDT
	{
		// Token: 0x1700E2C8 RID: 58056
		// (get) Token: 0x0603651A RID: 222490 RVA: 0x00761EC8 File Offset: 0x007600C8
		// (set) Token: 0x0603651B RID: 222491 RVA: 0x00761ED0 File Offset: 0x007600D0
		public EUiStyleTypeOfLevelD Type { get; set; }

		// Token: 0x1700E2C9 RID: 58057
		// (get) Token: 0x0603651C RID: 222492 RVA: 0x00761ED9 File Offset: 0x007600D9
		// (set) Token: 0x0603651D RID: 222493 RVA: 0x00761EE1 File Offset: 0x007600E1
		public IVector2T Position { get; set; }

		// Token: 0x1700E2CA RID: 58058
		// (get) Token: 0x0603651E RID: 222494 RVA: 0x00761EEA File Offset: 0x007600EA
		// (set) Token: 0x0603651F RID: 222495 RVA: 0x00761EF2 File Offset: 0x007600F2
		public IVector2T TextBoxSize { get; set; }

		// Token: 0x1700E2CB RID: 58059
		// (get) Token: 0x06036520 RID: 222496 RVA: 0x00761EFB File Offset: 0x007600FB
		// (set) Token: 0x06036521 RID: 222497 RVA: 0x00761F03 File Offset: 0x00760103
		public int FontSize { get; set; }

		// Token: 0x1700E2CC RID: 58060
		// (get) Token: 0x06036522 RID: 222498 RVA: 0x00761F0C File Offset: 0x0076010C
		// (set) Token: 0x06036523 RID: 222499 RVA: 0x00761F14 File Offset: 0x00760114
		public float Duration { get; set; }

		// Token: 0x06036524 RID: 222500 RVA: 0x00761F1D File Offset: 0x0076011D
		public IUiStylePlayPianoOfLevelDT()
		{
			this.Type = EUiStyleTypeOfLevelD.GiantSubtitle;
			this.Position = null;
			this.TextBoxSize = null;
			this.FontSize = 0;
			this.Duration = 0f;
		}
	}
}
