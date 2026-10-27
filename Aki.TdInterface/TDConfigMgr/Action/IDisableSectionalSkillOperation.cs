using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B6 RID: 6582
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableSectionalSkillOperationConverter))]
	public class IDisableSectionalSkillOperation : ISkillOperationType
	{
		// Token: 0x06008CFD RID: 36093 RVA: 0x0014A950 File Offset: 0x00148B50
		[NullableContext(1)]
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

		// Token: 0x06008CFE RID: 36094 RVA: 0x0014A988 File Offset: 0x00148B88
		[NullableContext(1)]
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

		// Token: 0x06008CFF RID: 36095 RVA: 0x0014A99B File Offset: 0x00148B9B
		[NullableContext(1)]
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

		// Token: 0x06008D00 RID: 36096 RVA: 0x0014A9B0 File Offset: 0x00148BB0
		[NullableContext(1)]
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

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x06008D01 RID: 36097 RVA: 0x0014AA16 File Offset: 0x00148C16
		// (set) Token: 0x06008D02 RID: 36098 RVA: 0x0014AA41 File Offset: 0x00148C41
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

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x0014AA50 File Offset: 0x00148C50
		// (set) Token: 0x06008D04 RID: 36100 RVA: 0x0014AA8A File Offset: 0x00148C8A
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

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x0014AA98 File Offset: 0x00148C98
		// (set) Token: 0x06008D06 RID: 36102 RVA: 0x0014AAF9 File Offset: 0x00148CF9
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

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x0014AB10 File Offset: 0x00148D10
		// (set) Token: 0x06008D08 RID: 36104 RVA: 0x0014AB4A File Offset: 0x00148D4A
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

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x06008D09 RID: 36105 RVA: 0x0014AB58 File Offset: 0x00148D58
		// (set) Token: 0x06008D0A RID: 36106 RVA: 0x0014ABB9 File Offset: 0x00148DB9
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

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x0014ABD0 File Offset: 0x00148DD0
		// (set) Token: 0x06008D0C RID: 36108 RVA: 0x0014AC0A File Offset: 0x00148E0A
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

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x0014AC18 File Offset: 0x00148E18
		// (set) Token: 0x06008D0E RID: 36110 RVA: 0x0014AC52 File Offset: 0x00148E52
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

		// Token: 0x040057A9 RID: 22441
		protected new IDisableSectionalSkillOperation FbInstance;

		// Token: 0x040057AA RID: 22442
		protected new IDisableSectionalSkillOperation_SetValue PocoInterface;

		// Token: 0x040057AB RID: 22443
		[Nullable(1)]
		private IDisableExploreSkill _DisableExploreSkillCache;

		// Token: 0x040057AC RID: 22444
		private bool _DisableExploreSkillInited;

		// Token: 0x040057AD RID: 22445
		[Nullable(1)]
		private IDisableBattleSkillOptions _DisableBattleSkillCache;

		// Token: 0x040057AE RID: 22446
		private bool _DisableBattleSkillInited;
	}
}
