using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BDB RID: 19419
	public interface IBossPilingTaskInfo
	{
		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x06030789 RID: 198537
		// (set) Token: 0x0603078A RID: 198538
		int Id { get; set; }

		// Token: 0x17006144 RID: 24900
		// (get) Token: 0x0603078B RID: 198539
		// (set) Token: 0x0603078C RID: 198540
		int Current { get; set; }

		// Token: 0x17006145 RID: 24901
		// (get) Token: 0x0603078D RID: 198541
		// (set) Token: 0x0603078E RID: 198542
		int Target { get; set; }

		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x0603078F RID: 198543
		// (set) Token: 0x06030790 RID: 198544
		ConditionTaskState Status { get; set; }
	}
}
