using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x02005262 RID: 21090
	[NullableContext(1)]
	public interface IPinballWeaponEquipViewData
	{
		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x060347D9 RID: 215001
		// (set) Token: 0x060347DA RID: 215002
		PinballActivityData ActivityData { get; set; }

		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x060347DB RID: 215003
		// (set) Token: 0x060347DC RID: 215004
		PinballRoleDataBase RoleData { get; set; }
	}
}
