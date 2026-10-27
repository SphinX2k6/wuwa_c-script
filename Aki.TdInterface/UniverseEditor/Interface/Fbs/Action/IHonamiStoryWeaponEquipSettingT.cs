using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006937 RID: 26935
	public class IHonamiStoryWeaponEquipSettingT
	{
		// Token: 0x1700C7D9 RID: 51161
		// (get) Token: 0x0602F084 RID: 192644 RVA: 0x006696D4 File Offset: 0x006678D4
		// (set) Token: 0x0602F085 RID: 192645 RVA: 0x006696DC File Offset: 0x006678DC
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x1700C7DA RID: 51162
		// (get) Token: 0x0602F086 RID: 192646 RVA: 0x006696E5 File Offset: 0x006678E5
		// (set) Token: 0x0602F087 RID: 192647 RVA: 0x006696ED File Offset: 0x006678ED
		public int WeaponId { get; set; }

		// Token: 0x0602F088 RID: 192648 RVA: 0x006696F6 File Offset: 0x006678F6
		public IHonamiStoryWeaponEquipSettingT()
		{
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.WeaponId = 0;
		}
	}
}
