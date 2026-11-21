using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D89 RID: 11657
	public class HonamiStorySetFormation : ActionParams
	{
		// Token: 0x0600FE29 RID: 65065 RVA: 0x0024AB76 File Offset: 0x00248D76
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

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x0600FE2A RID: 65066 RVA: 0x0024AB95 File Offset: 0x00248D95
		public virtual int ActivityId
		{
			get
			{
				return this.Instance.ActivityId;
			}
		}

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x0600FE2B RID: 65067 RVA: 0x0024ABA4 File Offset: 0x00248DA4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IHonamiStoryRoleSetting> RoleSetting
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x0600FE2C RID: 65068 RVA: 0x0024AC20 File Offset: 0x00248E20
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IHonamiStoryWeaponEquipSetting> WeaponSetting
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x0600FE2D RID: 65069 RVA: 0x0024AC9C File Offset: 0x00248E9C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IHonamiStoryPluginEquipSetting> PluginSetting
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04008ABB RID: 35515
		private IHonamiStorySetFormation Instance;

		// Token: 0x04008ABC RID: 35516
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHonamiStoryRoleSetting> _RoleSettingCache;

		// Token: 0x04008ABD RID: 35517
		private bool _RoleSettingInited;

		// Token: 0x04008ABE RID: 35518
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHonamiStoryWeaponEquipSetting> _WeaponSettingCache;

		// Token: 0x04008ABF RID: 35519
		private bool _WeaponSettingInited;

		// Token: 0x04008AC0 RID: 35520
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHonamiStoryPluginEquipSetting> _PluginSettingCache;

		// Token: 0x04008AC1 RID: 35521
		private bool _PluginSettingInited;
	}
}
