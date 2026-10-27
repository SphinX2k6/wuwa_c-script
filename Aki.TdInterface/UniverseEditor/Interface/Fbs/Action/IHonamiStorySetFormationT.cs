using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006934 RID: 26932
	public class IHonamiStorySetFormationT
	{
		// Token: 0x1700C7D1 RID: 51153
		// (get) Token: 0x0602F068 RID: 192616 RVA: 0x00669405 File Offset: 0x00667605
		// (set) Token: 0x0602F069 RID: 192617 RVA: 0x0066940D File Offset: 0x0066760D
		public int ActivityId { get; set; }

		// Token: 0x1700C7D2 RID: 51154
		// (get) Token: 0x0602F06A RID: 192618 RVA: 0x00669416 File Offset: 0x00667616
		// (set) Token: 0x0602F06B RID: 192619 RVA: 0x0066941E File Offset: 0x0066761E
		public List<IHonamiStoryRoleSettingT> RoleSetting { get; set; }

		// Token: 0x1700C7D3 RID: 51155
		// (get) Token: 0x0602F06C RID: 192620 RVA: 0x00669427 File Offset: 0x00667627
		// (set) Token: 0x0602F06D RID: 192621 RVA: 0x0066942F File Offset: 0x0066762F
		public List<IHonamiStoryWeaponEquipSettingT> WeaponSetting { get; set; }

		// Token: 0x1700C7D4 RID: 51156
		// (get) Token: 0x0602F06E RID: 192622 RVA: 0x00669438 File Offset: 0x00667638
		// (set) Token: 0x0602F06F RID: 192623 RVA: 0x00669440 File Offset: 0x00667640
		public List<IHonamiStoryPluginEquipSettingT> PluginSetting { get; set; }

		// Token: 0x1700C7D5 RID: 51157
		// (get) Token: 0x0602F070 RID: 192624 RVA: 0x00669449 File Offset: 0x00667649
		// (set) Token: 0x0602F071 RID: 192625 RVA: 0x00669451 File Offset: 0x00667651
		public byte NullMask { get; set; }

		// Token: 0x0602F072 RID: 192626 RVA: 0x0066945A File Offset: 0x0066765A
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
