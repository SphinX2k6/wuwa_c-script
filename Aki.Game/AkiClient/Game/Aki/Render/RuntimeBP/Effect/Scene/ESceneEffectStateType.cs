using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003109 RID: 12553
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/ESceneEffectStateType.ESceneEffectStateType")]
	public enum ESceneEffectStateType : byte
	{
		// Token: 0x040104FE RID: 66814
		AirWall,
		// Token: 0x040104FF RID: 66815
		ToxicFog,
		// Token: 0x04010500 RID: 66816
		ESceneEffectStateType_MAX
	}
}
