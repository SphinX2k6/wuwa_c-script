using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Enum
{
	// Token: 0x020040B6 RID: 16566
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Enum/EWeaponViewName.EWeaponViewName")]
	public enum EWeaponViewName : byte
	{
		// Token: 0x0401627D RID: 90749
		None,
		// Token: 0x0401627E RID: 90750
		RoleWeaponTabView,
		// Token: 0x0401627F RID: 90751
		WeaponLevelUpView,
		// Token: 0x04016280 RID: 90752
		WeaponResonanceView,
		// Token: 0x04016281 RID: 90753
		WeaponReplaceView,
		// Token: 0x04016282 RID: 90754
		GachaScanView,
		// Token: 0x04016283 RID: 90755
		EWeaponViewName_MAX
	}
}
