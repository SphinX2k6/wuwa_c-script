using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Enum
{
	// Token: 0x020032AA RID: 12970
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Enum/EWeaponViewName.EWeaponViewName")]
	public enum EWeaponViewName : byte
	{
		// Token: 0x04011A36 RID: 72246
		None,
		// Token: 0x04011A37 RID: 72247
		RoleWeaponTabView,
		// Token: 0x04011A38 RID: 72248
		WeaponLevelUpView,
		// Token: 0x04011A39 RID: 72249
		WeaponResonanceView,
		// Token: 0x04011A3A RID: 72250
		WeaponReplaceView,
		// Token: 0x04011A3B RID: 72251
		GachaScanView,
		// Token: 0x04011A3C RID: 72252
		EWeaponViewName_MAX
	}
}
