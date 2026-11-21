using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D0 RID: 6352
	public class HonamiStorySetFormation_SetValue
	{
		// Token: 0x040054AA RID: 21674
		public int ActivityId;

		// Token: 0x040054AB RID: 21675
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IHonamiStoryRoleSetting> RoleSetting;

		// Token: 0x040054AC RID: 21676
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IHonamiStoryWeaponEquipSetting> WeaponSetting;

		// Token: 0x040054AD RID: 21677
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IHonamiStoryPluginEquipSetting> PluginSetting;
	}
}
