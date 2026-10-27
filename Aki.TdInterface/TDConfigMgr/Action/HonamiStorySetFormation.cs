using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200174E RID: 5966
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStorySetFormation : ActionParams
	{
		// Token: 0x06007E3F RID: 32319 RVA: 0x0012E59C File Offset: 0x0012C79C
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

		// Token: 0x06007E40 RID: 32320 RVA: 0x0012E5D4 File Offset: 0x0012C7D4
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

		// Token: 0x06007E41 RID: 32321 RVA: 0x0012E5E7 File Offset: 0x0012C7E7
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

		// Token: 0x06007E42 RID: 32322 RVA: 0x0012E5FA File Offset: 0x0012C7FA
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

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x0012E631 File Offset: 0x0012C831
		// (set) Token: 0x06007E44 RID: 32324 RVA: 0x0012E65C File Offset: 0x0012C85C
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

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x0012E66C File Offset: 0x0012C86C
		// (set) Token: 0x06007E46 RID: 32326 RVA: 0x0012E6FF File Offset: 0x0012C8FF
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().RoleSetting = value;
				this._RoleSettingInited = false;
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x0012E714 File Offset: 0x0012C914
		// (set) Token: 0x06007E48 RID: 32328 RVA: 0x0012E7A7 File Offset: 0x0012C9A7
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().WeaponSetting = value;
				this._WeaponSettingInited = false;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x0012E7BC File Offset: 0x0012C9BC
		// (set) Token: 0x06007E4A RID: 32330 RVA: 0x0012E84F File Offset: 0x0012CA4F
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().PluginSetting = value;
				this._PluginSettingInited = false;
			}
		}

		// Token: 0x0400506C RID: 20588
		[Nullable(2)]
		protected new HonamiStorySetFormation FbInstance;

		// Token: 0x0400506D RID: 20589
		[Nullable(2)]
		protected HonamiStorySetFormation_SetValue PocoInterface;

		// Token: 0x0400506E RID: 20590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHonamiStoryRoleSetting> _RoleSettingCache;

		// Token: 0x0400506F RID: 20591
		private bool _RoleSettingInited;

		// Token: 0x04005070 RID: 20592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHonamiStoryWeaponEquipSetting> _WeaponSettingCache;

		// Token: 0x04005071 RID: 20593
		private bool _WeaponSettingInited;

		// Token: 0x04005072 RID: 20594
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHonamiStoryPluginEquipSetting> _PluginSettingCache;

		// Token: 0x04005073 RID: 20595
		private bool _PluginSettingInited;
	}
}
