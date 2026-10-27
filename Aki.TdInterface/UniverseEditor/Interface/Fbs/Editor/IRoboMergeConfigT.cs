using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A2 RID: 18594
	public class IRoboMergeConfigT
	{
		// Token: 0x170086D7 RID: 34519
		// (get) Token: 0x0601D05C RID: 118876 RVA: 0x004196C5 File Offset: 0x004178C5
		// (set) Token: 0x0601D05D RID: 118877 RVA: 0x004196CD File Offset: 0x004178CD
		public string WorkspaceBranch { get; set; }

		// Token: 0x0601D05E RID: 118878 RVA: 0x004196D6 File Offset: 0x004178D6
		public IRoboMergeConfigT()
		{
			this.WorkspaceBranch = null;
		}
	}
}
