using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x0200525B RID: 21083
	[NullableContext(1)]
	public interface IPinballWeaponEquipTipItemData
	{
		// Token: 0x170065F7 RID: 26103
		// (get) Token: 0x060347A6 RID: 214950
		// (set) Token: 0x060347A7 RID: 214951
		PinballWeaponData WeaponData { get; set; }

		// Token: 0x170065F8 RID: 26104
		// (get) Token: 0x060347A8 RID: 214952
		// (set) Token: 0x060347A9 RID: 214953
		bool ShowButton { get; set; }

		// Token: 0x170065F9 RID: 26105
		// (get) Token: 0x060347AA RID: 214954
		// (set) Token: 0x060347AB RID: 214955
		EPinballWeaponEquipState State { get; set; }

		// Token: 0x170065FA RID: 26106
		// (get) Token: 0x060347AC RID: 214956
		// (set) Token: 0x060347AD RID: 214957
		Action ConfirmDelegate { get; set; }
	}
}
