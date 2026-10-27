using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E1 RID: 25313
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTitleItemData : IPinballWeaponEquipTitleItemData
	{
		// Token: 0x170092A0 RID: 37536
		// (get) Token: 0x0603FB07 RID: 260871 RVA: 0x00F68C0E File Offset: 0x00F66E0E
		// (set) Token: 0x0603FB08 RID: 260872 RVA: 0x00F68C16 File Offset: 0x00F66E16
		public string TypeIconPath { get; set; }

		// Token: 0x170092A1 RID: 37537
		// (get) Token: 0x0603FB09 RID: 260873 RVA: 0x00F68C1F File Offset: 0x00F66E1F
		// (set) Token: 0x0603FB0A RID: 260874 RVA: 0x00F68C27 File Offset: 0x00F66E27
		public TableTextArgNew DescTextData { get; set; }

		// Token: 0x170092A2 RID: 37538
		// (get) Token: 0x0603FB0B RID: 260875 RVA: 0x00F68C30 File Offset: 0x00F66E30
		// (set) Token: 0x0603FB0C RID: 260876 RVA: 0x00F68C38 File Offset: 0x00F66E38
		public bool CanEquip { get; set; }
	}
}
