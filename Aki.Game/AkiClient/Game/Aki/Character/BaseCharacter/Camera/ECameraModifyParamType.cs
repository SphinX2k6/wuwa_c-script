using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A8 RID: 17320
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraModifyParamType.ECameraModifyParamType")]
	public enum ECameraModifyParamType : byte
	{
		// Token: 0x04017AF4 RID: 97012
		数值,
		// Token: 0x04017AF5 RID: 97013
		曲线,
		// Token: 0x04017AF6 RID: 97014
		ECameraModifyParamType_MAX
	}
}
