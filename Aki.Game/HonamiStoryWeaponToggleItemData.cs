using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x020013CD RID: 5069
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryWeaponToggleItemData : IHonamiStoryWeaponToggleItemData
{
	// Token: 0x17001346 RID: 4934
	// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x003BC488 File Offset: 0x003BA688
	// (set) Token: 0x0600C8D2 RID: 51410 RVA: 0x003BC490 File Offset: 0x003BA690
	public int WeaponId { get; set; }

	// Token: 0x17001347 RID: 4935
	// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x003BC499 File Offset: 0x003BA699
	// (set) Token: 0x0600C8D4 RID: 51412 RVA: 0x003BC4A1 File Offset: 0x003BA6A1
	public HonamiStoryRoleEquipData EquipData { get; set; }

	// Token: 0x17001348 RID: 4936
	// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x003BC4AA File Offset: 0x003BA6AA
	// (set) Token: 0x0600C8D6 RID: 51414 RVA: 0x003BC4B2 File Offset: 0x003BA6B2
	public EHonamiStoryWeaponUseWay UseWay { get; set; }
}
