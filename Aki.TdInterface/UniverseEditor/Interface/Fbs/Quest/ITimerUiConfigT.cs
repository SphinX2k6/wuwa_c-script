using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004638 RID: 17976
	public class ITimerUiConfigT
	{
		// Token: 0x17007DCA RID: 32202
		// (get) Token: 0x0601A510 RID: 107792 RVA: 0x003BEF23 File Offset: 0x003BD123
		// (set) Token: 0x0601A511 RID: 107793 RVA: 0x003BEF2B File Offset: 0x003BD12B
		public ETimerUiType UiType { get; set; }

		// Token: 0x17007DCB RID: 32203
		// (get) Token: 0x0601A512 RID: 107794 RVA: 0x003BEF34 File Offset: 0x003BD134
		// (set) Token: 0x0601A513 RID: 107795 RVA: 0x003BEF3C File Offset: 0x003BD13C
		public string TidTitle { get; set; }

		// Token: 0x0601A514 RID: 107796 RVA: 0x003BEF45 File Offset: 0x003BD145
		public ITimerUiConfigT()
		{
			this.UiType = ETimerUiType.Default;
			this.TidTitle = null;
		}
	}
}
