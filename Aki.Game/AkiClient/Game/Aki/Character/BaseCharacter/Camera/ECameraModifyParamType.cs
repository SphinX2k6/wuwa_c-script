using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C6 RID: 13254
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraModifyParamType.ECameraModifyParamType")]
	public enum ECameraModifyParamType : byte
	{
		// Token: 0x04012666 RID: 75366
		数值,
		// Token: 0x04012667 RID: 75367
		曲线,
		// Token: 0x04012668 RID: 75368
		ECameraModifyParamType_MAX
	}
}
