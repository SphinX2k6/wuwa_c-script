using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006453 RID: 25683
	public class IOutAreaBorderDownTimeTextTipT
	{
		// Token: 0x1700BD9F RID: 48543
		// (get) Token: 0x0602BA64 RID: 178788 RVA: 0x005F10F6 File Offset: 0x005EF2F6
		// (set) Token: 0x0602BA65 RID: 178789 RVA: 0x005F10FE File Offset: 0x005EF2FE
		public EOutAreaBorderTipType Type { get; set; }

		// Token: 0x0602BA66 RID: 178790 RVA: 0x005F1107 File Offset: 0x005EF307
		public IOutAreaBorderDownTimeTextTipT()
		{
			this.Type = EOutAreaBorderTipType.DownTimeTextTip;
		}
	}
}
