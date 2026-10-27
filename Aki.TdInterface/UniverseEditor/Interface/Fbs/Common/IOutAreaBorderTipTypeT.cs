using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E22 RID: 24098
	public class IOutAreaBorderTipTypeT
	{
		// Token: 0x1700B44C RID: 46156
		// (get) Token: 0x0602942C RID: 169004 RVA: 0x005A8C72 File Offset: 0x005A6E72
		// (set) Token: 0x0602942D RID: 169005 RVA: 0x005A8C7A File Offset: 0x005A6E7A
		public EOutAreaBorderTipType Type { get; set; }

		// Token: 0x0602942E RID: 169006 RVA: 0x005A8C83 File Offset: 0x005A6E83
		public IOutAreaBorderTipTypeT()
		{
			this.Type = EOutAreaBorderTipType.DownTimeTextTip;
		}
	}
}
