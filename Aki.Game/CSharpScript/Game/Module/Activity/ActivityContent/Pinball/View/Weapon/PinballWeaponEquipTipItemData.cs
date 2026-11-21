using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x0200525C RID: 21084
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTipItemData : IPinballWeaponEquipTipItemData
	{
		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x060347AE RID: 214958 RVA: 0x00EAF76E File Offset: 0x00EAD96E
		// (set) Token: 0x060347AF RID: 214959 RVA: 0x00EAF776 File Offset: 0x00EAD976
		public PinballWeaponData WeaponData { get; set; }

		// Token: 0x170065FC RID: 26108
		// (get) Token: 0x060347B0 RID: 214960 RVA: 0x00EAF77F File Offset: 0x00EAD97F
		// (set) Token: 0x060347B1 RID: 214961 RVA: 0x00EAF787 File Offset: 0x00EAD987
		public bool ShowButton { get; set; }

		// Token: 0x170065FD RID: 26109
		// (get) Token: 0x060347B2 RID: 214962 RVA: 0x00EAF790 File Offset: 0x00EAD990
		// (set) Token: 0x060347B3 RID: 214963 RVA: 0x00EAF798 File Offset: 0x00EAD998
		public EPinballWeaponEquipState State { get; set; }

		// Token: 0x170065FE RID: 26110
		// (get) Token: 0x060347B4 RID: 214964 RVA: 0x00EAF7A1 File Offset: 0x00EAD9A1
		// (set) Token: 0x060347B5 RID: 214965 RVA: 0x00EAF7A9 File Offset: 0x00EAD9A9
		public Action ConfirmDelegate { get; set; }
	}
}
