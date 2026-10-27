using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E5 RID: 25317
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipViewData : IPinballWeaponEquipViewData
	{
		// Token: 0x170092A7 RID: 37543
		// (get) Token: 0x0603FB1C RID: 260892 RVA: 0x00F68D92 File Offset: 0x00F66F92
		// (set) Token: 0x0603FB1D RID: 260893 RVA: 0x00F68D9A File Offset: 0x00F66F9A
		public PinballActivityData ActivityData { get; set; }

		// Token: 0x170092A8 RID: 37544
		// (get) Token: 0x0603FB1E RID: 260894 RVA: 0x00F68DA3 File Offset: 0x00F66FA3
		// (set) Token: 0x0603FB1F RID: 260895 RVA: 0x00F68DAB File Offset: 0x00F66FAB
		public PinballRoleDataBase RoleData { get; set; }
	}
}
