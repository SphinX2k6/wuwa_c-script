using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A95 RID: 10901
	public class HonamiStorySetFormation : ActionParams
	{
		// Token: 0x0600EF73 RID: 61299 RVA: 0x0022CE6A File Offset: 0x0022B06A
		[NullableContext(1)]
		public static HonamiStorySetFormation Create(IHonamiStorySetFormation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStorySetFormation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x0600EF74 RID: 61300 RVA: 0x0022CE89 File Offset: 0x0022B089
		public virtual int ActivityId
		{
			get
			{
				return this.Instance.ActivityId;
			}
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x0600EF75 RID: 61301 RVA: 0x0022CE98 File Offset: 0x0022B098
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IHonamiStoryRoleSetting> RoleSetting
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._RoleSettingInited)
				{
					return this._RoleSettingCache;
				}
				this._RoleSettingInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int roleSettingLength = this.Instance.RoleSettingLength;
				this._RoleSettingCache = new List<IHonamiStoryRoleSetting>(roleSettingLength);
				for (int i = 0; i < roleSettingLength; i++)
				{
					this._RoleSettingCache.Add(IHonamiStoryRoleSetting.Create(this.Instance.RoleSetting(i)));
				}
				return this._RoleSettingCache;
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x0600EF76 RID: 61302 RVA: 0x0022CF14 File Offset: 0x0022B114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IHonamiStoryWeaponEquipSetting> WeaponSetting
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._WeaponSettingInited)
				{
					return this._WeaponSettingCache;
				}
				this._WeaponSettingInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int weaponSettingLength = this.Instance.WeaponSettingLength;
				this._WeaponSettingCache = new List<IHonamiStoryWeaponEquipSetting>(weaponSettingLength);
				for (int i = 0; i < weaponSettingLength; i++)
				{
					this._WeaponSettingCache.Add(IHonamiStoryWeaponEquipSetting.Create(this.Instance.WeaponSetting(i)));
				}
				return this._WeaponSettingCache;
			}
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x0600EF77 RID: 61303 RVA: 0x0022CF90 File Offset: 0x0022B190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IHonamiStoryPluginEquipSetting> PluginSetting
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._PluginSettingInited)
				{
					return this._PluginSettingCache;
				}
				this._PluginSettingInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int pluginSettingLength = this.Instance.PluginSettingLength;
				this._PluginSettingCache = new List<IHonamiStoryPluginEquipSetting>(pluginSettingLength);
				for (int i = 0; i < pluginSettingLength; i++)
				{
					this._PluginSettingCache.Add(IHonamiStoryPluginEquipSetting.Create(this.Instance.PluginSetting(i)));
				}
				return this._PluginSettingCache;
			}
		}

		// Token: 0x040083B7 RID: 33719
		private IHonamiStorySetFormation Instance;

		// Token: 0x040083B8 RID: 33720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHonamiStoryRoleSetting> _RoleSettingCache;

		// Token: 0x040083B9 RID: 33721
		private bool _RoleSettingInited;

		// Token: 0x040083BA RID: 33722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHonamiStoryWeaponEquipSetting> _WeaponSettingCache;

		// Token: 0x040083BB RID: 33723
		private bool _WeaponSettingInited;

		// Token: 0x040083BC RID: 33724
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHonamiStoryPluginEquipSetting> _PluginSettingCache;

		// Token: 0x040083BD RID: 33725
		private bool _PluginSettingInited;
	}
}
