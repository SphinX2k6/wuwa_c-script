using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001F0A RID: 7946
[NullableContext(2)]
public interface IHonamiStoryWeaponToggleItemData
{
	// Token: 0x17001319 RID: 4889
	// (get) Token: 0x0600F4AC RID: 62636
	// (set) Token: 0x0600F4AD RID: 62637
	int WeaponId { get; set; }

	// Token: 0x1700131A RID: 4890
	// (get) Token: 0x0600F4AE RID: 62638
	// (set) Token: 0x0600F4AF RID: 62639
	HonamiStoryRoleEquipData EquipData { get; set; }

	// Token: 0x1700131B RID: 4891
	// (get) Token: 0x0600F4B0 RID: 62640
	// (set) Token: 0x0600F4B1 RID: 62641
	EHonamiStoryWeaponUseWay UseWay { get; set; }
}
