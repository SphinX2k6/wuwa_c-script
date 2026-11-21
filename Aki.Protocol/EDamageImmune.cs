using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200162D RID: 5677
	public enum EDamageImmune
	{
		// Token: 0x0400C186 RID: 49542
		[OriginalName("EDamageImmune_Default")]
		Default,
		// Token: 0x0400C187 RID: 49543
		[OriginalName("EDamageImmune_Invincible")]
		Invincible,
		// Token: 0x0400C188 RID: 49544
		[OriginalName("EDamageImmune_BuffEffectElement")]
		BuffEffectElement,
		// Token: 0x0400C189 RID: 49545
		[OriginalName("EDamageImmune_BulletCurNoCtrl")]
		BulletCurNoCtrl,
		// Token: 0x0400C18A RID: 49546
		[OriginalName("EDamageImmune_VehiclePassenger")]
		VehiclePassenger,
		// Token: 0x0400C18B RID: 49547
		[OriginalName("EDamageImmune_FishBoat")]
		FishBoat,
		// Token: 0x0400C18C RID: 49548
		[OriginalName("EDamageImmune_Revive")]
		Revive
	}
}
