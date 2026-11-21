using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F9 RID: 13049
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECaughtDirectionType.ECaughtDirectionType")]
	public enum ECaughtDirectionType : byte
	{
		// Token: 0x04011FF4 RID: 73716
		CaughtDirection,
		// Token: 0x04011FF5 RID: 73717
		BoxDirection,
		// Token: 0x04011FF6 RID: 73718
		SpeedDirection,
		// Token: 0x04011FF7 RID: 73719
		None,
		// Token: 0x04011FF8 RID: 73720
		ECaughtDirectionType_MAX
	}
}
