using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D57 RID: 27991
	public class IPlotModeUiStyleBaseT
	{
		// Token: 0x1700D0C1 RID: 53441
		// (get) Token: 0x060316CC RID: 202444 RVA: 0x006B3A52 File Offset: 0x006B1C52
		// (set) Token: 0x060316CD RID: 202445 RVA: 0x006B3A5A File Offset: 0x006B1C5A
		public EPlotModeUiStyleType Type { get; set; }

		// Token: 0x060316CE RID: 202446 RVA: 0x006B3A63 File Offset: 0x006B1C63
		public IPlotModeUiStyleBaseT()
		{
			this.Type = EPlotModeUiStyleType.LevelD;
		}
	}
}
