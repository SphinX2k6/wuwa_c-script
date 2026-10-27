using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001F0B RID: 7947
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryWeaponToggleItemData : IHonamiStoryWeaponToggleItemData
{
	// Token: 0x1700131C RID: 4892
	// (get) Token: 0x0600F4B2 RID: 62642 RVA: 0x003B0994 File Offset: 0x003AEB94
	// (set) Token: 0x0600F4B3 RID: 62643 RVA: 0x003B099C File Offset: 0x003AEB9C
	public int WeaponId { get; set; }

	// Token: 0x1700131D RID: 4893
	// (get) Token: 0x0600F4B4 RID: 62644 RVA: 0x003B09A5 File Offset: 0x003AEBA5
	// (set) Token: 0x0600F4B5 RID: 62645 RVA: 0x003B09AD File Offset: 0x003AEBAD
	public HonamiStoryRoleEquipData EquipData { get; set; }

	// Token: 0x1700131E RID: 4894
	// (get) Token: 0x0600F4B6 RID: 62646 RVA: 0x003B09B6 File Offset: 0x003AEBB6
	// (set) Token: 0x0600F4B7 RID: 62647 RVA: 0x003B09BE File Offset: 0x003AEBBE
	public EHonamiStoryWeaponUseWay UseWay { get; set; }
}
