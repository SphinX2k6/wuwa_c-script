using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x02005263 RID: 21091
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipViewData : IPinballWeaponEquipViewData
	{
		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x060347DD RID: 215005 RVA: 0x00EAFCEE File Offset: 0x00EADEEE
		// (set) Token: 0x060347DE RID: 215006 RVA: 0x00EAFCF6 File Offset: 0x00EADEF6
		public PinballActivityData ActivityData { get; set; }

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x060347DF RID: 215007 RVA: 0x00EAFCFF File Offset: 0x00EADEFF
		// (set) Token: 0x060347E0 RID: 215008 RVA: 0x00EAFD07 File Offset: 0x00EADF07
		public PinballRoleDataBase RoleData { get; set; }
	}
}
