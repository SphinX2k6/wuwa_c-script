using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B43 RID: 6979
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableSectionalSkillOperationConverter))]
	public class IDisableSectionalSkillOperation : ISkillOperationType
	{
		// Token: 0x0600943F RID: 37951 RVA: 0x0015A45C File Offset: 0x0015865C
		[NullableContext(0)]
		private IDisableSectionalSkillOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableSectionalSkillOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableSectionalSkillOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableSectionalSkillOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009440 RID: 37952 RVA: 0x0015A494 File Offset: 0x00158694
		[NullableContext(0)]
		public static IDisableSectionalSkillOperation Create([Nullable(2)] IDisableSectionalSkillOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSectionalSkillOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x0015A4A7 File Offset: 0x001586A7
		[NullableContext(0)]
		public static IDisableSectionalSkillOperation CreateFromSetValue([Nullable(2)] IDisableSectionalSkillOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableSectionalSkillOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x0015A4BC File Offset: 0x001586BC
		[NullableContext(0)]
		public new IDisableSectionalSkillOperation_SetValue ToSetValue()
		{
			return new IDisableSectionalSkillOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode,
				DisableExploreSkill = this.DisableExploreSkill,
				DisableSkillWheel = this.DisableSkillWheel,
				DisableBattleSkill = this.DisableBattleSkill,
				DisableSwitchRole = this.DisableSwitchRole,
				TeamDisplayMode = this.TeamDisplayMode
			};
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x06009443 RID: 37955 RVA: 0x0015A522 File Offset: 0x00158722
		// (set) Token: 0x06009444 RID: 37956 RVA: 0x0015A54D File Offset: 0x0015874D
		public override ESkillOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkillOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x06009445 RID: 37957 RVA: 0x0015A55C File Offset: 0x0015875C
		// (set) Token: 0x06009446 RID: 37958 RVA: 0x0015A596 File Offset: 0x00158796
		public virtual EDisplayModeInSkillOp? DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IDisableSectionalSkillOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayMode;
			}
			set
			{
				this.GetOrCreatePoco().DisplayMode = value;
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x06009447 RID: 37959 RVA: 0x0015A5A4 File Offset: 0x001587A4
		// (set) Token: 0x06009448 RID: 37960 RVA: 0x0015A605 File Offset: 0x00158805
		public virtual IDisableExploreSkill DisableExploreSkill
		{
			get
			{
				if (this._DisableExploreSkillInited)
				{
					return this._DisableExploreSkillCache;
				}
				this._DisableExploreSkillInited = true;
				if (this.FbInstance != null)
				{
					this._DisableExploreSkillCache = IDisableExploreSkill.Create(this.FbInstance.DisableExploreSkill);
				}
				else
				{
					IDisableSectionalSkillOperation_SetValue pocoInterface = this.PocoInterface;
					this._DisableExploreSkillCache = ((pocoInterface != null) ? pocoInterface.DisableExploreSkill : null);
				}
				return this._DisableExploreSkillCache;
			}
			set
			{
				this.GetOrCreatePoco().DisableExploreSkill = value;
				this._DisableExploreSkillInited = false;
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x06009449 RID: 37961 RVA: 0x0015A61C File Offset: 0x0015881C
		// (set) Token: 0x0600944A RID: 37962 RVA: 0x0015A656 File Offset: 0x00158856
		public virtual bool? DisableSkillWheel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSkillWheel;
				}
				IDisableSectionalSkillOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSkillWheel;
			}
			set
			{
				this.GetOrCreatePoco().DisableSkillWheel = value;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600944B RID: 37963 RVA: 0x0015A664 File Offset: 0x00158864
		// (set) Token: 0x0600944C RID: 37964 RVA: 0x0015A6C5 File Offset: 0x001588C5
		public virtual IDisableBattleSkillOptions DisableBattleSkill
		{
			get
			{
				if (this._DisableBattleSkillInited)
				{
					return this._DisableBattleSkillCache;
				}
				this._DisableBattleSkillInited = true;
				if (this.FbInstance != null)
				{
					this._DisableBattleSkillCache = IDisableBattleSkillOptions.Create(this.FbInstance.DisableBattleSkill);
				}
				else
				{
					IDisableSectionalSkillOperation_SetValue pocoInterface = this.PocoInterface;
					this._DisableBattleSkillCache = ((pocoInterface != null) ? pocoInterface.DisableBattleSkill : null);
				}
				return this._DisableBattleSkillCache;
			}
			set
			{
				this.GetOrCreatePoco().DisableBattleSkill = value;
				this._DisableBattleSkillInited = false;
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600944D RID: 37965 RVA: 0x0015A6DC File Offset: 0x001588DC
		// (set) Token: 0x0600944E RID: 37966 RVA: 0x0015A716 File Offset: 0x00158916
		public virtual bool? DisableSwitchRole
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSwitchRole;
				}
				IDisableSectionalSkillOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSwitchRole;
			}
			set
			{
				this.GetOrCreatePoco().DisableSwitchRole = value;
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600944F RID: 37967 RVA: 0x0015A724 File Offset: 0x00158924
		// (set) Token: 0x06009450 RID: 37968 RVA: 0x0015A75E File Offset: 0x0015895E
		public virtual ETeamDisplayModeInSkillOp? TeamDisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeamDisplayMode;
				}
				IDisableSectionalSkillOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TeamDisplayMode;
			}
			set
			{
				this.GetOrCreatePoco().TeamDisplayMode = value;
			}
		}

		// Token: 0x04005BFE RID: 23550
		protected new IDisableSectionalSkillOperation FbInstance;

		// Token: 0x04005BFF RID: 23551
		protected new IDisableSectionalSkillOperation_SetValue PocoInterface;

		// Token: 0x04005C00 RID: 23552
		[Nullable(0)]
		private IDisableExploreSkill _DisableExploreSkillCache;

		// Token: 0x04005C01 RID: 23553
		private bool _DisableExploreSkillInited;

		// Token: 0x04005C02 RID: 23554
		[Nullable(0)]
		private IDisableBattleSkillOptions _DisableBattleSkillCache;

		// Token: 0x04005C03 RID: 23555
		private bool _DisableBattleSkillInited;
	}
}
