using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C64 RID: 7268
	[NullableContext(1)]
	[Nullable(0)]
	public class INotifyMonsterPlayStandbyTags : ISendBattleStateType
	{
		// Token: 0x06009BE5 RID: 39909 RVA: 0x00165C8C File Offset: 0x00163E8C
		private INotifyMonsterPlayStandbyTags_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INotifyMonsterPlayStandbyTags 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INotifyMonsterPlayStandbyTags_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INotifyMonsterPlayStandbyTags_SetValue());
			}
			return result;
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x00165CC4 File Offset: 0x00163EC4
		public static INotifyMonsterPlayStandbyTags Create([Nullable(2)] INotifyMonsterPlayStandbyTags instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INotifyMonsterPlayStandbyTags
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x00165CD7 File Offset: 0x00163ED7
		public static INotifyMonsterPlayStandbyTags CreateFromSetValue([Nullable(2)] INotifyMonsterPlayStandbyTags_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INotifyMonsterPlayStandbyTags
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x00165CEA File Offset: 0x00163EEA
		public new INotifyMonsterPlayStandbyTags_SetValue ToSetValue()
		{
			return new INotifyMonsterPlayStandbyTags_SetValue
			{
				Type = this.Type,
				StandbyConfigs = this.StandbyConfigs
			};
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x06009BE9 RID: 39913 RVA: 0x00165D09 File Offset: 0x00163F09
		// (set) Token: 0x06009BEA RID: 39914 RVA: 0x00165D34 File Offset: 0x00163F34
		public override ESetBattleStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x00165D44 File Offset: 0x00163F44
		// (set) Token: 0x06009BEC RID: 39916 RVA: 0x00165DD7 File Offset: 0x00163FD7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMonsterStandByConfig> StandbyConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._StandbyConfigsInited)
				{
					return this._StandbyConfigsCache;
				}
				this._StandbyConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IMonsterStandByConfig> standbyConfigs = this.FbInstance.StandbyConfigs;
					if (standbyConfigs != null)
					{
						this._StandbyConfigsCache = new List<IMonsterStandByConfig>(standbyConfigs.Count);
						for (int i = 0; i < standbyConfigs.Count; i++)
						{
							this._StandbyConfigsCache.Add(IMonsterStandByConfig.Create(standbyConfigs[i]));
						}
					}
				}
				else
				{
					INotifyMonsterPlayStandbyTags_SetValue pocoInterface = this.PocoInterface;
					this._StandbyConfigsCache = ((pocoInterface != null) ? pocoInterface.StandbyConfigs : null);
				}
				return this._StandbyConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().StandbyConfigs = value;
				this._StandbyConfigsInited = false;
			}
		}

		// Token: 0x04005E9A RID: 24218
		[Nullable(2)]
		protected new INotifyMonsterPlayStandbyTags FbInstance;

		// Token: 0x04005E9B RID: 24219
		[Nullable(2)]
		protected new INotifyMonsterPlayStandbyTags_SetValue PocoInterface;

		// Token: 0x04005E9C RID: 24220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMonsterStandByConfig> _StandbyConfigsCache;

		// Token: 0x04005E9D RID: 24221
		private bool _StandbyConfigsInited;
	}
}
