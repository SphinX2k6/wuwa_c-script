using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE7 RID: 28647
	public class IHonamiStorySetFormationT
	{
		// Token: 0x1700D1D4 RID: 53716
		// (get) Token: 0x06031A38 RID: 203320 RVA: 0x006B98ED File Offset: 0x006B7AED
		// (set) Token: 0x06031A39 RID: 203321 RVA: 0x006B98F5 File Offset: 0x006B7AF5
		public int ActivityId { get; set; }

		// Token: 0x1700D1D5 RID: 53717
		// (get) Token: 0x06031A3A RID: 203322 RVA: 0x006B98FE File Offset: 0x006B7AFE
		// (set) Token: 0x06031A3B RID: 203323 RVA: 0x006B9906 File Offset: 0x006B7B06
		public List<IHonamiStoryRoleSettingT> RoleSetting { get; set; }

		// Token: 0x1700D1D6 RID: 53718
		// (get) Token: 0x06031A3C RID: 203324 RVA: 0x006B990F File Offset: 0x006B7B0F
		// (set) Token: 0x06031A3D RID: 203325 RVA: 0x006B9917 File Offset: 0x006B7B17
		public List<IHonamiStoryWeaponEquipSettingT> WeaponSetting { get; set; }

		// Token: 0x1700D1D7 RID: 53719
		// (get) Token: 0x06031A3E RID: 203326 RVA: 0x006B9920 File Offset: 0x006B7B20
		// (set) Token: 0x06031A3F RID: 203327 RVA: 0x006B9928 File Offset: 0x006B7B28
		public List<IHonamiStoryPluginEquipSettingT> PluginSetting { get; set; }

		// Token: 0x1700D1D8 RID: 53720
		// (get) Token: 0x06031A40 RID: 203328 RVA: 0x006B9931 File Offset: 0x006B7B31
		// (set) Token: 0x06031A41 RID: 203329 RVA: 0x006B9939 File Offset: 0x006B7B39
		public byte NullMask { get; set; }

		// Token: 0x06031A42 RID: 203330 RVA: 0x006B9942 File Offset: 0x006B7B42
		public IHonamiStorySetFormationT()
		{
			this.ActivityId = 0;
			this.RoleSetting = null;
			this.WeaponSetting = null;
			this.PluginSetting = null;
			this.NullMask = 0;
		}
	}
}
