using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DCD RID: 15821
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/ESceneEffectStateType.ESceneEffectStateType")]
	public enum ESceneEffectStateType : byte
	{
		// Token: 0x04013E7D RID: 81533
		AirWall,
		// Token: 0x04013E7E RID: 81534
		ToxicFog,
		// Token: 0x04013E7F RID: 81535
		ESceneEffectStateType_MAX
	}
}
