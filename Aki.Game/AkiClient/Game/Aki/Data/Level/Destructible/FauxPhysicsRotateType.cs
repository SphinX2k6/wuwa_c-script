using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Level.Destructible
{
	// Token: 0x02003F13 RID: 16147
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Destructible/FauxPhysicsRotateType.FauxPhysicsRotateType")]
	public enum FauxPhysicsRotateType : byte
	{
		// Token: 0x04014F9E RID: 85918
		AxisRotate,
		// Token: 0x04014F9F RID: 85919
		FreeRotate,
		// Token: 0x04014FA0 RID: 85920
		ConeRotate,
		// Token: 0x04014FA1 RID: 85921
		FauxPhysicsRotateType_MAX
	}
}
