using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016AB RID: 5803
	public enum RoleTowerStageState
	{
		// Token: 0x0400C574 RID: 50548
		[OriginalName("RoleTowerStageStateNotPass")]
		NotPass,
		// Token: 0x0400C575 RID: 50549
		[OriginalName("RoleTowerStageStateCurrent")]
		Current,
		// Token: 0x0400C576 RID: 50550
		[OriginalName("RoleTowerStageStatePassed")]
		Passed,
		// Token: 0x0400C577 RID: 50551
		[OriginalName("RoleTowerStageStateLocked")]
		Locked
	}
}
