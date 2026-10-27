using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E16 RID: 24086
	public class IOutAreaBorderDownTimeTextTipT
	{
		// Token: 0x1700B439 RID: 46137
		// (get) Token: 0x060293DA RID: 168922 RVA: 0x005A83C6 File Offset: 0x005A65C6
		// (set) Token: 0x060293DB RID: 168923 RVA: 0x005A83CE File Offset: 0x005A65CE
		public EOutAreaBorderTipType Type { get; set; }

		// Token: 0x060293DC RID: 168924 RVA: 0x005A83D7 File Offset: 0x005A65D7
		public IOutAreaBorderDownTimeTextTipT()
		{
			this.Type = EOutAreaBorderTipType.DownTimeTextTip;
		}
	}
}
