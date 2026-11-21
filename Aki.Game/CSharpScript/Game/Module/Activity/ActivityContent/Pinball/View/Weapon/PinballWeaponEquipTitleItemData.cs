using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x0200525F RID: 21087
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTitleItemData : IPinballWeaponEquipTitleItemData
	{
		// Token: 0x17006602 RID: 26114
		// (get) Token: 0x060347C8 RID: 214984 RVA: 0x00EAFB6A File Offset: 0x00EADD6A
		// (set) Token: 0x060347C9 RID: 214985 RVA: 0x00EAFB72 File Offset: 0x00EADD72
		public string TypeIconPath { get; set; }

		// Token: 0x17006603 RID: 26115
		// (get) Token: 0x060347CA RID: 214986 RVA: 0x00EAFB7B File Offset: 0x00EADD7B
		// (set) Token: 0x060347CB RID: 214987 RVA: 0x00EAFB83 File Offset: 0x00EADD83
		public TableTextArgNew DescTextData { get; set; }

		// Token: 0x17006604 RID: 26116
		// (get) Token: 0x060347CC RID: 214988 RVA: 0x00EAFB8C File Offset: 0x00EADD8C
		// (set) Token: 0x060347CD RID: 214989 RVA: 0x00EAFB94 File Offset: 0x00EADD94
		public bool CanEquip { get; set; }
	}
}
