using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AB RID: 30123
	public class IVisualNovelPerformanceExitT
	{
		// Token: 0x1700E490 RID: 58512
		// (get) Token: 0x06036D40 RID: 224576 RVA: 0x00771665 File Offset: 0x0076F865
		// (set) Token: 0x06036D41 RID: 224577 RVA: 0x0077166D File Offset: 0x0076F86D
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E491 RID: 58513
		// (get) Token: 0x06036D42 RID: 224578 RVA: 0x00771676 File Offset: 0x0076F876
		// (set) Token: 0x06036D43 RID: 224579 RVA: 0x0077167E File Offset: 0x0076F87E
		public float StartTime { get; set; }

		// Token: 0x1700E492 RID: 58514
		// (get) Token: 0x06036D44 RID: 224580 RVA: 0x00771687 File Offset: 0x0076F887
		// (set) Token: 0x06036D45 RID: 224581 RVA: 0x0077168F File Offset: 0x0076F88F
		public int WhoId { get; set; }

		// Token: 0x1700E493 RID: 58515
		// (get) Token: 0x06036D46 RID: 224582 RVA: 0x00771698 File Offset: 0x0076F898
		// (set) Token: 0x06036D47 RID: 224583 RVA: 0x007716A0 File Offset: 0x0076F8A0
		public bool AllExit { get; set; }

		// Token: 0x1700E494 RID: 58516
		// (get) Token: 0x06036D48 RID: 224584 RVA: 0x007716A9 File Offset: 0x0076F8A9
		// (set) Token: 0x06036D49 RID: 224585 RVA: 0x007716B1 File Offset: 0x0076F8B1
		public float FadeOutTime { get; set; }

		// Token: 0x1700E495 RID: 58517
		// (get) Token: 0x06036D4A RID: 224586 RVA: 0x007716BA File Offset: 0x0076F8BA
		// (set) Token: 0x06036D4B RID: 224587 RVA: 0x007716C2 File Offset: 0x0076F8C2
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700E496 RID: 58518
		// (get) Token: 0x06036D4C RID: 224588 RVA: 0x007716CB File Offset: 0x0076F8CB
		// (set) Token: 0x06036D4D RID: 224589 RVA: 0x007716D3 File Offset: 0x0076F8D3
		public byte NullMask { get; set; }

		// Token: 0x06036D4E RID: 224590 RVA: 0x007716DC File Offset: 0x0076F8DC
		public IVisualNovelPerformanceExitT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.AllExit = false;
			this.FadeOutTime = 0f;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
