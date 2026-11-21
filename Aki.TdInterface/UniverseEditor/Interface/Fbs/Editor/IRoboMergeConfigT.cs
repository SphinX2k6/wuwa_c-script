using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D07 RID: 19719
	public class IRoboMergeConfigT
	{
		// Token: 0x17008D1F RID: 36127
		// (get) Token: 0x0601E849 RID: 125001 RVA: 0x00445E61 File Offset: 0x00444061
		// (set) Token: 0x0601E84A RID: 125002 RVA: 0x00445E69 File Offset: 0x00444069
		public string WorkspaceBranch { get; set; }

		// Token: 0x0601E84B RID: 125003 RVA: 0x00445E72 File Offset: 0x00444072
		public IRoboMergeConfigT()
		{
			this.WorkspaceBranch = null;
		}
	}
}
