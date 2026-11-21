using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016E2 RID: 5858
	public enum TetrisState
	{
		// Token: 0x0400C6AE RID: 50862
		[OriginalName("TetrisLocked")]
		TetrisLocked,
		// Token: 0x0400C6AF RID: 50863
		[OriginalName("TetrisUnlocked")]
		TetrisUnlocked,
		// Token: 0x0400C6B0 RID: 50864
		[OriginalName("TetrisFinished")]
		TetrisFinished
	}
}
