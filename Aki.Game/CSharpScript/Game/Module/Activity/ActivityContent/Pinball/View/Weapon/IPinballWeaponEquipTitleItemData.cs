using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E0 RID: 25312
	[NullableContext(1)]
	public interface IPinballWeaponEquipTitleItemData
	{
		// Token: 0x1700929D RID: 37533
		// (get) Token: 0x0603FB01 RID: 260865
		// (set) Token: 0x0603FB02 RID: 260866
		string TypeIconPath { get; set; }

		// Token: 0x1700929E RID: 37534
		// (get) Token: 0x0603FB03 RID: 260867
		// (set) Token: 0x0603FB04 RID: 260868
		TableTextArgNew DescTextData { get; set; }

		// Token: 0x1700929F RID: 37535
		// (get) Token: 0x0603FB05 RID: 260869
		// (set) Token: 0x0603FB06 RID: 260870
		bool CanEquip { get; set; }
	}
}
