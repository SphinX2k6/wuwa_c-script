using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062DE RID: 25310
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTipItemData : IPinballWeaponEquipTipItemData
	{
		// Token: 0x17009299 RID: 37529
		// (get) Token: 0x0603FAED RID: 260845 RVA: 0x00F68812 File Offset: 0x00F66A12
		// (set) Token: 0x0603FAEE RID: 260846 RVA: 0x00F6881A File Offset: 0x00F66A1A
		public PinballWeaponData WeaponData { get; set; }

		// Token: 0x1700929A RID: 37530
		// (get) Token: 0x0603FAEF RID: 260847 RVA: 0x00F68823 File Offset: 0x00F66A23
		// (set) Token: 0x0603FAF0 RID: 260848 RVA: 0x00F6882B File Offset: 0x00F66A2B
		public bool ShowButton { get; set; }

		// Token: 0x1700929B RID: 37531
		// (get) Token: 0x0603FAF1 RID: 260849 RVA: 0x00F68834 File Offset: 0x00F66A34
		// (set) Token: 0x0603FAF2 RID: 260850 RVA: 0x00F6883C File Offset: 0x00F66A3C
		public EPinballWeaponEquipState State { get; set; }

		// Token: 0x1700929C RID: 37532
		// (get) Token: 0x0603FAF3 RID: 260851 RVA: 0x00F68845 File Offset: 0x00F66A45
		// (set) Token: 0x0603FAF4 RID: 260852 RVA: 0x00F6884D File Offset: 0x00F66A4D
		public Action ConfirmDelegate { get; set; }
	}
}
