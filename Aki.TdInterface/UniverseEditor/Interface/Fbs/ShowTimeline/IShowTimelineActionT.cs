using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B9C RID: 15260
	public class IShowTimelineActionT
	{
		// Token: 0x1700689A RID: 26778
		// (get) Token: 0x06014E93 RID: 85651 RVA: 0x00308BA5 File Offset: 0x00306DA5
		// (set) Token: 0x06014E94 RID: 85652 RVA: 0x00308BAD File Offset: 0x00306DAD
		public EShowTimelineType Type { get; set; }

		// Token: 0x1700689B RID: 26779
		// (get) Token: 0x06014E95 RID: 85653 RVA: 0x00308BB6 File Offset: 0x00306DB6
		// (set) Token: 0x06014E96 RID: 85654 RVA: 0x00308BBE File Offset: 0x00306DBE
		public EShowTimelineActionType ActionType { get; set; }

		// Token: 0x1700689C RID: 26780
		// (get) Token: 0x06014E97 RID: 85655 RVA: 0x00308BC7 File Offset: 0x00306DC7
		// (set) Token: 0x06014E98 RID: 85656 RVA: 0x00308BCF File Offset: 0x00306DCF
		public int ActionParam { get; set; }

		// Token: 0x1700689D RID: 26781
		// (get) Token: 0x06014E99 RID: 85657 RVA: 0x00308BD8 File Offset: 0x00306DD8
		// (set) Token: 0x06014E9A RID: 85658 RVA: 0x00308BE0 File Offset: 0x00306DE0
		public TShowTimelineActionOptionUnion ActionData { get; set; }

		// Token: 0x1700689E RID: 26782
		// (get) Token: 0x06014E9B RID: 85659 RVA: 0x00308BE9 File Offset: 0x00306DE9
		// (set) Token: 0x06014E9C RID: 85660 RVA: 0x00308BF1 File Offset: 0x00306DF1
		public IShowTimelineActionDisplayConfigT DisplayConfig { get; set; }

		// Token: 0x06014E9D RID: 85661 RVA: 0x00308BFA File Offset: 0x00306DFA
		public IShowTimelineActionT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.ActionType = EShowTimelineActionType.Skill;
			this.ActionParam = 0;
			this.ActionData = null;
			this.DisplayConfig = null;
		}
	}
}
