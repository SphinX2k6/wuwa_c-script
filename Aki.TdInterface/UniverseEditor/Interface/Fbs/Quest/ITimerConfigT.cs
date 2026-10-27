using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D9 RID: 16857
	public class ITimerConfigT
	{
		// Token: 0x17007787 RID: 30599
		// (get) Token: 0x06018D6B RID: 101739 RVA: 0x00392F55 File Offset: 0x00391155
		// (set) Token: 0x06018D6C RID: 101740 RVA: 0x00392F5D File Offset: 0x0039115D
		public int Time { get; set; }

		// Token: 0x17007788 RID: 30600
		// (get) Token: 0x06018D6D RID: 101741 RVA: 0x00392F66 File Offset: 0x00391166
		// (set) Token: 0x06018D6E RID: 101742 RVA: 0x00392F6E File Offset: 0x0039116E
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x17007789 RID: 30601
		// (get) Token: 0x06018D6F RID: 101743 RVA: 0x00392F77 File Offset: 0x00391177
		// (set) Token: 0x06018D70 RID: 101744 RVA: 0x00392F7F File Offset: 0x0039117F
		public ETimerType TimerType { get; set; }

		// Token: 0x1700778A RID: 30602
		// (get) Token: 0x06018D71 RID: 101745 RVA: 0x00392F88 File Offset: 0x00391188
		// (set) Token: 0x06018D72 RID: 101746 RVA: 0x00392F90 File Offset: 0x00391190
		public ITimerUiConfigT UiConfig { get; set; }

		// Token: 0x1700778B RID: 30603
		// (get) Token: 0x06018D73 RID: 101747 RVA: 0x00392F99 File Offset: 0x00391199
		// (set) Token: 0x06018D74 RID: 101748 RVA: 0x00392FA1 File Offset: 0x003911A1
		public byte NullMask { get; set; }

		// Token: 0x06018D75 RID: 101749 RVA: 0x00392FAA File Offset: 0x003911AA
		public ITimerConfigT()
		{
			this.Time = 0;
			this.VarForTime = null;
			this.TimerType = ETimerType.CountDownChallenge;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
