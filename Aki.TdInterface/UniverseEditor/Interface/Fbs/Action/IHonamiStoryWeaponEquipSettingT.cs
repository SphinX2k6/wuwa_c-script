using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEA RID: 28650
	public class IHonamiStoryWeaponEquipSettingT
	{
		// Token: 0x1700D1DC RID: 53724
		// (get) Token: 0x06031A54 RID: 203348 RVA: 0x006B9BBC File Offset: 0x006B7DBC
		// (set) Token: 0x06031A55 RID: 203349 RVA: 0x006B9BC4 File Offset: 0x006B7DC4
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x1700D1DD RID: 53725
		// (get) Token: 0x06031A56 RID: 203350 RVA: 0x006B9BCD File Offset: 0x006B7DCD
		// (set) Token: 0x06031A57 RID: 203351 RVA: 0x006B9BD5 File Offset: 0x006B7DD5
		public int WeaponId { get; set; }

		// Token: 0x06031A58 RID: 203352 RVA: 0x006B9BDE File Offset: 0x006B7DDE
		public IHonamiStoryWeaponEquipSettingT()
		{
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.WeaponId = 0;
		}
	}
}
