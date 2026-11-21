using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C4 RID: 13252
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraModifier_Settings_ArmLengthDynamicValueType.ECameraModifier_Settings_ArmLengthDynamicValueType")]
	public enum ECameraModifier_Settings_ArmLengthDynamicValueType : byte
	{
		// Token: 0x04012654 RID: 75348
		None,
		// Token: 0x04012655 RID: 75349
		技能Id,
		// Token: 0x04012656 RID: 75350
		ECameraModifier_Settings_MAX
	}
}
