using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159B RID: 5531
	public enum ELogicStateType
	{
		// Token: 0x0400A7DF RID: 42975
		[OriginalName("CharPositionState")]
		CharPositionState,
		// Token: 0x0400A7E0 RID: 42976
		[OriginalName("CharMoveState")]
		CharMoveState,
		// Token: 0x0400A7E1 RID: 42977
		[OriginalName("CharDirectionState")]
		CharDirectionState,
		// Token: 0x0400A7E2 RID: 42978
		[OriginalName("CharPositionSubState")]
		CharPositionSubState
	}
}
