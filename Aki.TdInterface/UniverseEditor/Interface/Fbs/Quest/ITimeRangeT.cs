using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D6 RID: 16854
	public class ITimeRangeT
	{
		// Token: 0x1700777F RID: 30591
		// (get) Token: 0x06018D48 RID: 101704 RVA: 0x0039291E File Offset: 0x00390B1E
		// (set) Token: 0x06018D49 RID: 101705 RVA: 0x00392926 File Offset: 0x00390B26
		public IDateTimeT StartTime { get; set; }

		// Token: 0x17007780 RID: 30592
		// (get) Token: 0x06018D4A RID: 101706 RVA: 0x0039292F File Offset: 0x00390B2F
		// (set) Token: 0x06018D4B RID: 101707 RVA: 0x00392937 File Offset: 0x00390B37
		public IDateTimeT EndTime { get; set; }

		// Token: 0x06018D4C RID: 101708 RVA: 0x00392940 File Offset: 0x00390B40
		public ITimeRangeT()
		{
			this.StartTime = null;
			this.EndTime = null;
		}
	}
}
