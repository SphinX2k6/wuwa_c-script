using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200593A RID: 22842
	[NullableContext(2)]
	[Nullable(0)]
	public class HonamiStoryWeaponSuitData : IHonamiStoryWeaponSuitData
	{
		// Token: 0x17008AF8 RID: 35576
		// (get) Token: 0x06039FFF RID: 237567 RVA: 0x00DCA528 File Offset: 0x00DC8728
		// (set) Token: 0x0603A000 RID: 237568 RVA: 0x00DCA530 File Offset: 0x00DC8730
		public int SuitId { get; set; }

		// Token: 0x17008AF9 RID: 35577
		// (get) Token: 0x0603A001 RID: 237569 RVA: 0x00DCA539 File Offset: 0x00DC8739
		// (set) Token: 0x0603A002 RID: 237570 RVA: 0x00DCA541 File Offset: 0x00DC8741
		public HonamiStoryRoleEquipData EquipData { get; set; }
	}
}
