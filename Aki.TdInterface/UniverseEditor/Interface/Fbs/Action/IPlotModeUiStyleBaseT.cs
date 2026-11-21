using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D2 RID: 29906
	public class IPlotModeUiStyleBaseT
	{
		// Token: 0x1700DC09 RID: 56329
		// (get) Token: 0x060346C8 RID: 214728 RVA: 0x0070F13A File Offset: 0x0070D33A
		// (set) Token: 0x060346C9 RID: 214729 RVA: 0x0070F142 File Offset: 0x0070D342
		public EPlotModeUiStyleType Type { get; set; }

		// Token: 0x060346CA RID: 214730 RVA: 0x0070F14B File Offset: 0x0070D34B
		public IPlotModeUiStyleBaseT()
		{
			this.Type = EPlotModeUiStyleType.LevelD;
		}
	}
}
