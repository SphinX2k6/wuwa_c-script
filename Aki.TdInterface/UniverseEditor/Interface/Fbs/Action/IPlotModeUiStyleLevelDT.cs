using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D8 RID: 29912
	public class IPlotModeUiStyleLevelDT
	{
		// Token: 0x1700DC0F RID: 56335
		// (get) Token: 0x060346EC RID: 214764 RVA: 0x0070F55B File Offset: 0x0070D75B
		// (set) Token: 0x060346ED RID: 214765 RVA: 0x0070F563 File Offset: 0x0070D763
		public EPlotModeUiStyleType Type { get; set; }

		// Token: 0x1700DC10 RID: 56336
		// (get) Token: 0x060346EE RID: 214766 RVA: 0x0070F56C File Offset: 0x0070D76C
		// (set) Token: 0x060346EF RID: 214767 RVA: 0x0070F574 File Offset: 0x0070D774
		public TUiStyleOfLevelDUnion UiStyle { get; set; }

		// Token: 0x060346F0 RID: 214768 RVA: 0x0070F57D File Offset: 0x0070D77D
		public IPlotModeUiStyleLevelDT()
		{
			this.Type = EPlotModeUiStyleType.LevelD;
			this.UiStyle = null;
		}
	}
}
