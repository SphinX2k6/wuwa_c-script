using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Seq_BP
{
	// Token: 0x02003A1F RID: 14879
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/ELoopStaticMeshMoveType.ELoopStaticMeshMoveType")]
	public enum ELoopStaticMeshMoveType : byte
	{
		// Token: 0x0400EFBA RID: 61370
		None,
		// Token: 0x0400EFBB RID: 61371
		MoveLoop,
		// Token: 0x0400EFBC RID: 61372
		MoveAtMoment,
		// Token: 0x0400EFBD RID: 61373
		MoveForever,
		// Token: 0x0400EFBE RID: 61374
		ELoopStaticMeshMoveType_MAX
	}
}
