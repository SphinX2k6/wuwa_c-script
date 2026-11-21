using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018CF RID: 6351
	public class HonamiStorySetFormation : ActionParams
	{
		// Token: 0x0600852F RID: 34095 RVA: 0x0013D7FC File Offset: 0x0013B9FC
		private HonamiStorySetFormation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HonamiStorySetFormation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HonamiStorySetFormation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HonamiStorySetFormation_SetValue());
			}
			return result;
		}

		// Token: 0x06008530 RID: 34096 RVA: 0x0013D834 File Offset: 0x0013BA34
		public static HonamiStorySetFormation Create([Nullable(2)] HonamiStorySetFormation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStorySetFormation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008531 RID: 34097 RVA: 0x0013D847 File Offset: 0x0013BA47
		public static HonamiStorySetFormation CreateFromSetValue([Nullable(2)] HonamiStorySetFormation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HonamiStorySetFormation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x0013D85A File Offset: 0x0013BA5A
		public HonamiStorySetFormation_SetValue ToSetValue()
		{
			return new HonamiStorySetFormation_SetValue
			{
				ActivityId = this.ActivityId,
				RoleSetting = this.RoleSetting,
				WeaponSetting = this.WeaponSetting,
				PluginSetting = this.PluginSetting
			};
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x0013D891 File Offset: 0x0013BA91
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x0013D8BC File Offset: 0x0013BABC
		public virtual int ActivityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActivityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActivityId;
			}
			set
			{
				this.GetOrCreatePoco().ActivityId = value;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x0013D8CC File Offset: 0x0013BACC
		// (set) Token: 0x06008536 RID: 34102 RVA: 0x0013D95F File Offset: 0x0013BB5F
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
				if (this.FbInstance != null)
				{
					List<IHonamiStoryRoleSetting> roleSetting = this.FbInstance.RoleSetting;
					if (roleSetting != null)
					{
						this._RoleSettingCache = new List<IHonamiStoryRoleSetting>(roleSetting.Count);
						for (int i = 0; i < roleSetting.Count; i++)
						{
							this._RoleSettingCache.Add(IHonamiStoryRoleSetting.Create(roleSetting[i]));
						}
					}
				}
				else
				{
					HonamiStorySetFormation_SetValue pocoInterface = this.PocoInterface;
					this._RoleSettingCache = ((pocoInterface != null) ? pocoInterface.RoleSetting : null);
				}
				return this._RoleSettingCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().RoleSetting = value;
				this._RoleSettingInited = false;
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x06008537 RID: 34103 RVA: 0x0013D974 File Offset: 0x0013BB74
		// (set) Token: 0x06008538 RID: 34104 RVA: 0x0013DA07 File Offset: 0x0013BC07
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
				if (this.FbInstance != null)
				{
					List<IHonamiStoryWeaponEquipSetting> weaponSetting = this.FbInstance.WeaponSetting;
					if (weaponSetting != null)
					{
						this._WeaponSettingCache = new List<IHonamiStoryWeaponEquipSetting>(weaponSetting.Count);
						for (int i = 0; i < weaponSetting.Count; i++)
						{
							this._WeaponSettingCache.Add(IHonamiStoryWeaponEquipSetting.Create(weaponSetting[i]));
						}
					}
				}
				else
				{
					HonamiStorySetFormation_SetValue pocoInterface = this.PocoInterface;
					this._WeaponSettingCache = ((pocoInterface != null) ? pocoInterface.WeaponSetting : null);
				}
				return this._WeaponSettingCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().WeaponSetting = value;
				this._WeaponSettingInited = false;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x06008539 RID: 34105 RVA: 0x0013DA1C File Offset: 0x0013BC1C
		// (set) Token: 0x0600853A RID: 34106 RVA: 0x0013DAAF File Offset: 0x0013BCAF
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
				if (this.FbInstance != null)
				{
					List<IHonamiStoryPluginEquipSetting> pluginSetting = this.FbInstance.PluginSetting;
					if (pluginSetting != null)
					{
						this._PluginSettingCache = new List<IHonamiStoryPluginEquipSetting>(pluginSetting.Count);
						for (int i = 0; i < pluginSetting.Count; i++)
						{
							this._PluginSettingCache.Add(IHonamiStoryPluginEquipSetting.Create(pluginSetting[i]));
						}
					}
				}
				else
				{
					HonamiStorySetFormation_SetValue pocoInterface = this.PocoInterface;
					this._PluginSettingCache = ((pocoInterface != null) ? pocoInterface.PluginSetting : null);
				}
				return this._PluginSettingCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().PluginSetting = value;
				this._PluginSettingInited = false;
			}
		}

		// Token: 0x040054A2 RID: 21666
		[Nullable(2)]
		protected new HonamiStorySetFormation FbInstance;

		// Token: 0x040054A3 RID: 21667
		[Nullable(2)]
		protected HonamiStorySetFormation_SetValue PocoInterface;

		// Token: 0x040054A4 RID: 21668
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHonamiStoryRoleSetting> _RoleSettingCache;

		// Token: 0x040054A5 RID: 21669
		private bool _RoleSettingInited;

		// Token: 0x040054A6 RID: 21670
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHonamiStoryWeaponEquipSetting> _WeaponSettingCache;

		// Token: 0x040054A7 RID: 21671
		private bool _WeaponSettingInited;

		// Token: 0x040054A8 RID: 21672
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHonamiStoryPluginEquipSetting> _PluginSettingCache;

		// Token: 0x040054A9 RID: 21673
		private bool _PluginSettingInited;
	}
}
