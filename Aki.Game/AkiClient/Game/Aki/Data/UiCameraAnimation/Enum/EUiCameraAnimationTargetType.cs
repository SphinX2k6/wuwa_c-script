using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x0200316B RID: 12651
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationTargetType.EUiCameraAnimationTargetType")]
	public enum EUiCameraAnimationTargetType : byte
	{
		// Token: 0x04010AC5 RID: 68293
		None,
		// Token: 0x04010AC6 RID: 68294
		Player,
		// Token: 0x04010AC7 RID: 68295
		Npc,
		// Token: 0x04010AC8 RID: 68296
		UiSceneRole,
		// Token: 0x04010AC9 RID: 68297
		UiSceneSkeletal,
		// Token: 0x04010ACA RID: 68298
		UiVisionHandBook,
		// Token: 0x04010ACB RID: 68299
		UiGlider,
		// Token: 0x04010ACC RID: 68300
		SailDock,
		// Token: 0x04010ACD RID: 68301
		UiSceneHulu,
		// Token: 0x04010ACE RID: 68302
		UiInfrastructure,
		// Token: 0x04010ACF RID: 68303
		UiSceneActor,
		// Token: 0x04010AD0 RID: 68304
		UiSceneFormationRole,
		// Token: 0x04010AD1 RID: 68305
		EUiCameraAnimationTargetType_MAX
	}
}
