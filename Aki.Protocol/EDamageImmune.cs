using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015BB RID: 5563
	public enum EDamageImmune
	{
		// Token: 0x0400BC93 RID: 48275
		[OriginalName("EDamageImmune_Default")]
		Default,
		// Token: 0x0400BC94 RID: 48276
		[OriginalName("EDamageImmune_Invincible")]
		Invincible,
		// Token: 0x0400BC95 RID: 48277
		[OriginalName("EDamageImmune_BuffEffectElement")]
		BuffEffectElement,
		// Token: 0x0400BC96 RID: 48278
		[OriginalName("EDamageImmune_BulletCurNoCtrl")]
		BulletCurNoCtrl,
		// Token: 0x0400BC97 RID: 48279
		[OriginalName("EDamageImmune_VehiclePassenger")]
		VehiclePassenger,
		// Token: 0x0400BC98 RID: 48280
		[OriginalName("EDamageImmune_FishBoat")]
		FishBoat,
		// Token: 0x0400BC99 RID: 48281
		[OriginalName("EDamageImmune_Revive")]
		Revive
	}
}
