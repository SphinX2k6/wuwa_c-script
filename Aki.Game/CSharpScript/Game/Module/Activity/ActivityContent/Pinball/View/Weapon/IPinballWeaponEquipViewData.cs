using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E4 RID: 25316
	[NullableContext(1)]
	public interface IPinballWeaponEquipViewData
	{
		// Token: 0x170092A5 RID: 37541
		// (get) Token: 0x0603FB18 RID: 260888
		// (set) Token: 0x0603FB19 RID: 260889
		PinballActivityData ActivityData { get; set; }

		// Token: 0x170092A6 RID: 37542
		// (get) Token: 0x0603FB1A RID: 260890
		// (set) Token: 0x0603FB1B RID: 260891
		PinballRoleDataBase RoleData { get; set; }
	}
}
