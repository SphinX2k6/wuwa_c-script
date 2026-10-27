using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005939 RID: 22841
	[NullableContext(2)]
	public interface IHonamiStoryWeaponSuitData
	{
		// Token: 0x17008AF6 RID: 35574
		// (get) Token: 0x06039FFB RID: 237563
		// (set) Token: 0x06039FFC RID: 237564
		int SuitId { get; set; }

		// Token: 0x17008AF7 RID: 35575
		// (get) Token: 0x06039FFD RID: 237565
		// (set) Token: 0x06039FFE RID: 237566
		HonamiStoryRoleEquipData EquipData { get; set; }
	}
}
