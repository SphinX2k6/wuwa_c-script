using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004913 RID: 18707
	[NullableContext(2)]
	[Nullable(0)]
	public class HonamiStoryWeaponSuitData : IHonamiStoryWeaponSuitData
	{
		// Token: 0x17005EC4 RID: 24260
		// (get) Token: 0x0602EF22 RID: 192290 RVA: 0x00D197DC File Offset: 0x00D179DC
		// (set) Token: 0x0602EF23 RID: 192291 RVA: 0x00D197E4 File Offset: 0x00D179E4
		public int SuitId { get; set; }

		// Token: 0x17005EC5 RID: 24261
		// (get) Token: 0x0602EF24 RID: 192292 RVA: 0x00D197ED File Offset: 0x00D179ED
		// (set) Token: 0x0602EF25 RID: 192293 RVA: 0x00D197F5 File Offset: 0x00D179F5
		public HonamiStoryRoleEquipData EquipData { get; set; }
	}
}
