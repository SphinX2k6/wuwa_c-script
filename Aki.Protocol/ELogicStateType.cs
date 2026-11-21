using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200160D RID: 5645
	public enum ELogicStateType
	{
		// Token: 0x0400AC5E RID: 44126
		[OriginalName("CharPositionState")]
		CharPositionState,
		// Token: 0x0400AC5F RID: 44127
		[OriginalName("CharMoveState")]
		CharMoveState,
		// Token: 0x0400AC60 RID: 44128
		[OriginalName("CharDirectionState")]
		CharDirectionState,
		// Token: 0x0400AC61 RID: 44129
		[OriginalName("CharPositionSubState")]
		CharPositionSubState
	}
}
