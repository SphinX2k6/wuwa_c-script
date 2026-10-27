using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02004345 RID: 17221
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/EWeaponType.EWeaponType")]
	public enum EWeaponType : byte
	{
		// Token: 0x040178B2 RID: 96434
		无,
		// Token: 0x040178B3 RID: 96435
		大刀,
		// Token: 0x040178B4 RID: 96436
		迅刀,
		// Token: 0x040178B5 RID: 96437
		双枪,
		// Token: 0x040178B6 RID: 96438
		拳套,
		// Token: 0x040178B7 RID: 96439
		法器,
		// Token: 0x040178B8 RID: 96440
		EWeaponType_MAX
	}
}
