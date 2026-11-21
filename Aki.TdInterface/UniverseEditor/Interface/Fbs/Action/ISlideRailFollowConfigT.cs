using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200791B RID: 31003
	public class ISlideRailFollowConfigT
	{
		// Token: 0x1700E365 RID: 58213
		// (get) Token: 0x0603696E RID: 223598 RVA: 0x0074E58F File Offset: 0x0074C78F
		// (set) Token: 0x0603696F RID: 223599 RVA: 0x0074E597 File Offset: 0x0074C797
		public int EntityId { get; set; }

		// Token: 0x1700E366 RID: 58214
		// (get) Token: 0x06036970 RID: 223600 RVA: 0x0074E5A0 File Offset: 0x0074C7A0
		// (set) Token: 0x06036971 RID: 223601 RVA: 0x0074E5A8 File Offset: 0x0074C7A8
		public string FollowDaPath { get; set; }

		// Token: 0x06036972 RID: 223602 RVA: 0x0074E5B1 File Offset: 0x0074C7B1
		public ISlideRailFollowConfigT()
		{
			this.EntityId = 0;
			this.FollowDaPath = null;
		}
	}
}
