using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A6 RID: 17318
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraModifier_Settings_ArmLengthDynamicValueType.ECameraModifier_Settings_ArmLengthDynamicValueType")]
	public enum ECameraModifier_Settings_ArmLengthDynamicValueType : byte
	{
		// Token: 0x04017AE2 RID: 96994
		None,
		// Token: 0x04017AE3 RID: 96995
		技能Id,
		// Token: 0x04017AE4 RID: 96996
		ECameraModifier_Settings_MAX
	}
}
