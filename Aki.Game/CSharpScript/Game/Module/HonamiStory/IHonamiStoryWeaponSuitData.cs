using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004912 RID: 18706
	[NullableContext(2)]
	public interface IHonamiStoryWeaponSuitData
	{
		// Token: 0x17005EC2 RID: 24258
		// (get) Token: 0x0602EF1E RID: 192286
		// (set) Token: 0x0602EF1F RID: 192287
		int SuitId { get; set; }

		// Token: 0x17005EC3 RID: 24259
		// (get) Token: 0x0602EF20 RID: 192288
		// (set) Token: 0x0602EF21 RID: 192289
		HonamiStoryRoleEquipData EquipData { get; set; }
	}
}
