using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5D RID: 7773
	public class INotifyMonsterPlayStandbyTags : ISendBattleStateType
	{
		// Token: 0x0600A545 RID: 42309 RVA: 0x00179088 File Offset: 0x00177288
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

		// Token: 0x0600A546 RID: 42310 RVA: 0x001790C0 File Offset: 0x001772C0
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

		// Token: 0x0600A547 RID: 42311 RVA: 0x001790D3 File Offset: 0x001772D3
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

		// Token: 0x0600A548 RID: 42312 RVA: 0x001790E6 File Offset: 0x001772E6
		public new INotifyMonsterPlayStandbyTags_SetValue ToSetValue()
		{
			return new INotifyMonsterPlayStandbyTags_SetValue
			{
				Type = this.Type,
				StandbyConfigs = this.StandbyConfigs
			};
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600A549 RID: 42313 RVA: 0x00179105 File Offset: 0x00177305
		// (set) Token: 0x0600A54A RID: 42314 RVA: 0x00179130 File Offset: 0x00177330
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

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600A54B RID: 42315 RVA: 0x00179140 File Offset: 0x00177340
		// (set) Token: 0x0600A54C RID: 42316 RVA: 0x001791D3 File Offset: 0x001773D3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMonsterStandByConfig> StandbyConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().StandbyConfigs = value;
				this._StandbyConfigsInited = false;
			}
		}

		// Token: 0x040063D4 RID: 25556
		[Nullable(2)]
		protected new INotifyMonsterPlayStandbyTags FbInstance;

		// Token: 0x040063D5 RID: 25557
		[Nullable(2)]
		protected new INotifyMonsterPlayStandbyTags_SetValue PocoInterface;

		// Token: 0x040063D6 RID: 25558
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMonsterStandByConfig> _StandbyConfigsCache;

		// Token: 0x040063D7 RID: 25559
		private bool _StandbyConfigsInited;
	}
}
