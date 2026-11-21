using System;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks
{
	// Token: 0x02000003 RID: 3
	public enum PlayerLoopTiming
	{
		// Token: 0x04000003 RID: 3
		PrePhysics,
		// Token: 0x04000004 RID: 4
		StartPhysics,
		// Token: 0x04000005 RID: 5
		DuringPhysics,
		// Token: 0x04000006 RID: 6
		EndPhysics,
		// Token: 0x04000007 RID: 7
		PostPhysics,
		// Token: 0x04000008 RID: 8
		PostUpdateWork,
		// Token: 0x04000009 RID: 9
		LastDemotable,
		// Token: 0x0400000A RID: 10
		MAX
	}
}
