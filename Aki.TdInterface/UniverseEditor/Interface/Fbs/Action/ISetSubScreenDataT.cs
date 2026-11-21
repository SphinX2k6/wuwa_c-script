using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200784C RID: 30796
	public class ISetSubScreenDataT
	{
		// Token: 0x1700E1E9 RID: 57833
		// (get) Token: 0x06036289 RID: 221833 RVA: 0x00741476 File Offset: 0x0073F676
		// (set) Token: 0x0603628A RID: 221834 RVA: 0x0074147E File Offset: 0x0073F67E
		public TScreenUnion TargetScreen { get; set; }

		// Token: 0x1700E1EA RID: 57834
		// (get) Token: 0x0603628B RID: 221835 RVA: 0x00741487 File Offset: 0x0073F687
		// (set) Token: 0x0603628C RID: 221836 RVA: 0x0074148F File Offset: 0x0073F68F
		public ISubScreenConfigT TargetSubScreenConfig { get; set; }

		// Token: 0x1700E1EB RID: 57835
		// (get) Token: 0x0603628D RID: 221837 RVA: 0x00741498 File Offset: 0x0073F698
		// (set) Token: 0x0603628E RID: 221838 RVA: 0x007414A0 File Offset: 0x0073F6A0
		public ISubScreenTransitionT Transition { get; set; }

		// Token: 0x0603628F RID: 221839 RVA: 0x007414A9 File Offset: 0x0073F6A9
		public ISetSubScreenDataT()
		{
			this.TargetScreen = null;
			this.TargetSubScreenConfig = null;
			this.Transition = null;
		}
	}
}
