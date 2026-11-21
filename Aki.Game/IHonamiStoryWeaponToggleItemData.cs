using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x020013CC RID: 5068
[NullableContext(2)]
public interface IHonamiStoryWeaponToggleItemData
{
	// Token: 0x17001343 RID: 4931
	// (get) Token: 0x0600C8CB RID: 51403
	// (set) Token: 0x0600C8CC RID: 51404
	int WeaponId { get; set; }

	// Token: 0x17001344 RID: 4932
	// (get) Token: 0x0600C8CD RID: 51405
	// (set) Token: 0x0600C8CE RID: 51406
	HonamiStoryRoleEquipData EquipData { get; set; }

	// Token: 0x17001345 RID: 4933
	// (get) Token: 0x0600C8CF RID: 51407
	// (set) Token: 0x0600C8D0 RID: 51408
	EHonamiStoryWeaponUseWay UseWay { get; set; }
}
