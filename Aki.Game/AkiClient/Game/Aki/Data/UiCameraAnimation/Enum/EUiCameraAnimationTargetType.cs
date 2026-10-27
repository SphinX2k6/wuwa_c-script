using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x02003E94 RID: 16020
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationTargetType.EUiCameraAnimationTargetType")]
	public enum EUiCameraAnimationTargetType : byte
	{
		// Token: 0x04014A44 RID: 84548
		None,
		// Token: 0x04014A45 RID: 84549
		Player,
		// Token: 0x04014A46 RID: 84550
		Npc,
		// Token: 0x04014A47 RID: 84551
		UiSceneRole,
		// Token: 0x04014A48 RID: 84552
		UiSceneSkeletal,
		// Token: 0x04014A49 RID: 84553
		UiVisionHandBook,
		// Token: 0x04014A4A RID: 84554
		UiGlider,
		// Token: 0x04014A4B RID: 84555
		SailDock,
		// Token: 0x04014A4C RID: 84556
		UiSceneHulu,
		// Token: 0x04014A4D RID: 84557
		UiInfrastructure,
		// Token: 0x04014A4E RID: 84558
		UiSceneActor,
		// Token: 0x04014A4F RID: 84559
		UiSceneFormationRole,
		// Token: 0x04014A50 RID: 84560
		EUiCameraAnimationTargetType_MAX
	}
}
