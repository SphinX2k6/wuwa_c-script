using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001666 RID: 5734
	public enum TetrisState
	{
		// Token: 0x0400C185 RID: 49541
		[OriginalName("TetrisLocked")]
		TetrisLocked,
		// Token: 0x0400C186 RID: 49542
		[OriginalName("TetrisUnlocked")]
		TetrisUnlocked,
		// Token: 0x0400C187 RID: 49543
		[OriginalName("TetrisFinished")]
		TetrisFinished
	}
}
