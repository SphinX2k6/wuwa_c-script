using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020040B4 RID: 16564
	public class AvgTalkerEnterActionContext
	{
		// Token: 0x17005450 RID: 21584
		// (get) Token: 0x06029E7F RID: 171647 RVA: 0x00BD9897 File Offset: 0x00BD7A97
		// (set) Token: 0x06029E80 RID: 171648 RVA: 0x00BD989F File Offset: 0x00BD7A9F
		public int CharacterId { get; set; }

		// Token: 0x17005451 RID: 21585
		// (get) Token: 0x06029E81 RID: 171649 RVA: 0x00BD98A8 File Offset: 0x00BD7AA8
		// (set) Token: 0x06029E82 RID: 171650 RVA: 0x00BD98B0 File Offset: 0x00BD7AB0
		public EAvgRolePosition Position { get; set; }

		// Token: 0x17005452 RID: 21586
		// (get) Token: 0x06029E83 RID: 171651 RVA: 0x00BD98B9 File Offset: 0x00BD7AB9
		// (set) Token: 0x06029E84 RID: 171652 RVA: 0x00BD98C1 File Offset: 0x00BD7AC1
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x06029E85 RID: 171653 RVA: 0x00BD98CA File Offset: 0x00BD7ACA
		// (set) Token: 0x06029E86 RID: 171654 RVA: 0x00BD98D2 File Offset: 0x00BD7AD2
		public bool IsLoop { get; set; }
	}
}
