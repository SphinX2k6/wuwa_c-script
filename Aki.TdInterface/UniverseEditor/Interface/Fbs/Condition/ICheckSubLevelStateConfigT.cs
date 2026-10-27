using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B33 RID: 19251
	public class ICheckSubLevelStateConfigT
	{
		// Token: 0x17008BAA RID: 35754
		// (get) Token: 0x0601E4B8 RID: 124088 RVA: 0x0043ED3B File Offset: 0x0043CF3B
		// (set) Token: 0x0601E4B9 RID: 124089 RVA: 0x0043ED43 File Offset: 0x0043CF43
		public string SubLevelName { get; set; }

		// Token: 0x17008BAB RID: 35755
		// (get) Token: 0x0601E4BA RID: 124090 RVA: 0x0043ED4C File Offset: 0x0043CF4C
		// (set) Token: 0x0601E4BB RID: 124091 RVA: 0x0043ED54 File Offset: 0x0043CF54
		public ESubLevelState SubLevelState { get; set; }

		// Token: 0x0601E4BC RID: 124092 RVA: 0x0043ED5D File Offset: 0x0043CF5D
		public ICheckSubLevelStateConfigT()
		{
			this.SubLevelName = null;
			this.SubLevelState = ESubLevelState.Enable;
		}
	}
}
