using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BFB RID: 23547
	public interface IBossPilingTaskInfo
	{
		// Token: 0x17008D71 RID: 36209
		// (get) Token: 0x0603B83E RID: 243774
		// (set) Token: 0x0603B83F RID: 243775
		int Id { get; set; }

		// Token: 0x17008D72 RID: 36210
		// (get) Token: 0x0603B840 RID: 243776
		// (set) Token: 0x0603B841 RID: 243777
		int Current { get; set; }

		// Token: 0x17008D73 RID: 36211
		// (get) Token: 0x0603B842 RID: 243778
		// (set) Token: 0x0603B843 RID: 243779
		int Target { get; set; }

		// Token: 0x17008D74 RID: 36212
		// (get) Token: 0x0603B844 RID: 243780
		// (set) Token: 0x0603B845 RID: 243781
		ConditionTaskState Status { get; set; }
	}
}
