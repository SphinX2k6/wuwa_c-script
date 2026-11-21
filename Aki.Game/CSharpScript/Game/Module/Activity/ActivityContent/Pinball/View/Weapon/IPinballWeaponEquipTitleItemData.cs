using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x0200525E RID: 21086
	[NullableContext(1)]
	public interface IPinballWeaponEquipTitleItemData
	{
		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x060347C2 RID: 214978
		// (set) Token: 0x060347C3 RID: 214979
		string TypeIconPath { get; set; }

		// Token: 0x17006600 RID: 26112
		// (get) Token: 0x060347C4 RID: 214980
		// (set) Token: 0x060347C5 RID: 214981
		TableTextArgNew DescTextData { get; set; }

		// Token: 0x17006601 RID: 26113
		// (get) Token: 0x060347C6 RID: 214982
		// (set) Token: 0x060347C7 RID: 214983
		bool CanEquip { get; set; }
	}
}
