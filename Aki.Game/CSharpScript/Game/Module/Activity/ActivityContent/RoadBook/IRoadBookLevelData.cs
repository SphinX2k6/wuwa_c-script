using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005142 RID: 20802
	public interface IRoadBookLevelData
	{
		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x0603405D RID: 213085
		// (set) Token: 0x0603405E RID: 213086
		int Id { get; set; }

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x0603405F RID: 213087
		// (set) Token: 0x06034060 RID: 213088
		int Level { get; set; }

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x06034061 RID: 213089
		// (set) Token: 0x06034062 RID: 213090
		int AccumulateExp { get; set; }

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x06034063 RID: 213091
		// (set) Token: 0x06034064 RID: 213092
		int TargetExp { get; set; }
	}
}
