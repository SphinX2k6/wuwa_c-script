using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200174F RID: 5967
	public class HonamiStorySetFormation_SetValue
	{
		// Token: 0x04005074 RID: 20596
		public int ActivityId;

		// Token: 0x04005075 RID: 20597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IHonamiStoryRoleSetting> RoleSetting;

		// Token: 0x04005076 RID: 20598
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IHonamiStoryWeaponEquipSetting> WeaponSetting;

		// Token: 0x04005077 RID: 20599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IHonamiStoryPluginEquipSetting> PluginSetting;
	}
}
