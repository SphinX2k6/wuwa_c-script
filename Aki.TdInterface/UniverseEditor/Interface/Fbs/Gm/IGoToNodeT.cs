using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ADB RID: 19163
	public class IGoToNodeT
	{
		// Token: 0x17008653 RID: 34387
		// (get) Token: 0x0601CDDE RID: 118238 RVA: 0x00410740 File Offset: 0x0040E940
		// (set) Token: 0x0601CDDF RID: 118239 RVA: 0x00410748 File Offset: 0x0040E948
		public EGmCommand Type { get; set; }

		// Token: 0x17008654 RID: 34388
		// (get) Token: 0x0601CDE0 RID: 118240 RVA: 0x00410751 File Offset: 0x0040E951
		// (set) Token: 0x0601CDE1 RID: 118241 RVA: 0x00410759 File Offset: 0x0040E959
		public EGoToNodeTreeType TreeType { get; set; }

		// Token: 0x17008655 RID: 34389
		// (get) Token: 0x0601CDE2 RID: 118242 RVA: 0x00410762 File Offset: 0x0040E962
		// (set) Token: 0x0601CDE3 RID: 118243 RVA: 0x0041076A File Offset: 0x0040E96A
		public int TreeId { get; set; }

		// Token: 0x17008656 RID: 34390
		// (get) Token: 0x0601CDE4 RID: 118244 RVA: 0x00410773 File Offset: 0x0040E973
		// (set) Token: 0x0601CDE5 RID: 118245 RVA: 0x0041077B File Offset: 0x0040E97B
		public int NodeId { get; set; }

		// Token: 0x0601CDE6 RID: 118246 RVA: 0x00410784 File Offset: 0x0040E984
		public IGoToNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.TreeType = EGoToNodeTreeType.None;
			this.TreeId = 0;
			this.NodeId = 0;
		}
	}
}
