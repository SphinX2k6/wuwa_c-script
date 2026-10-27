using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.MagneticStorm.Data
{
	// Token: 0x02003CEE RID: 15598
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/MagneticStorm/Data/E_MagneticStorm_RegionType.E_MagneticStorm_RegionType")]
	public enum E_MagneticStorm_RegionType : byte
	{
		// Token: 0x04012843 RID: 75843
		Box,
		// Token: 0x04012844 RID: 75844
		Hemisphere,
		// Token: 0x04012845 RID: 75845
		E_MagneticStorm_MAX
	}
}
