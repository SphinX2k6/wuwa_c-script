using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062DD RID: 25309
	[NullableContext(1)]
	public interface IPinballWeaponEquipTipItemData
	{
		// Token: 0x17009295 RID: 37525
		// (get) Token: 0x0603FAE5 RID: 260837
		// (set) Token: 0x0603FAE6 RID: 260838
		PinballWeaponData WeaponData { get; set; }

		// Token: 0x17009296 RID: 37526
		// (get) Token: 0x0603FAE7 RID: 260839
		// (set) Token: 0x0603FAE8 RID: 260840
		bool ShowButton { get; set; }

		// Token: 0x17009297 RID: 37527
		// (get) Token: 0x0603FAE9 RID: 260841
		// (set) Token: 0x0603FAEA RID: 260842
		EPinballWeaponEquipState State { get; set; }

		// Token: 0x17009298 RID: 37528
		// (get) Token: 0x0603FAEB RID: 260843
		// (set) Token: 0x0603FAEC RID: 260844
		Action ConfirmDelegate { get; set; }
	}
}
