using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE9 RID: 19689
	public class ILevelPlayAreaConflictSelectorT
	{
		// Token: 0x17008CE9 RID: 36073
		// (get) Token: 0x0601E73B RID: 124731 RVA: 0x00443FC6 File Offset: 0x004421C6
		// (set) Token: 0x0601E73C RID: 124732 RVA: 0x00443FCE File Offset: 0x004421CE
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x17008CEA RID: 36074
		// (get) Token: 0x0601E73D RID: 124733 RVA: 0x00443FD7 File Offset: 0x004421D7
		// (set) Token: 0x0601E73E RID: 124734 RVA: 0x00443FDF File Offset: 0x004421DF
		public int Id { get; set; }

		// Token: 0x17008CEB RID: 36075
		// (get) Token: 0x0601E73F RID: 124735 RVA: 0x00443FE8 File Offset: 0x004421E8
		// (set) Token: 0x0601E740 RID: 124736 RVA: 0x00443FF0 File Offset: 0x004421F0
		public bool CheckEnterArea { get; set; }

		// Token: 0x0601E741 RID: 124737 RVA: 0x00443FF9 File Offset: 0x004421F9
		public ILevelPlayAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
			this.Id = 0;
			this.CheckEnterArea = false;
		}
	}
}
