using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002029 RID: 8233
	public class ISendBattleEvents : IExecBattleActionType
	{
		// Token: 0x0600AEC7 RID: 44743 RVA: 0x00189ED0 File Offset: 0x001880D0
		private ISendBattleEvents_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendBattleEvents 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendBattleEvents_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendBattleEvents_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x00189F08 File Offset: 0x00188108
		public static ISendBattleEvents Create([Nullable(2)] ISendBattleEvents instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEvents
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x00189F1B File Offset: 0x0018811B
		public static ISendBattleEvents CreateFromSetValue([Nullable(2)] ISendBattleEvents_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendBattleEvents
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x00189F2E File Offset: 0x0018812E
		public new ISendBattleEvents_SetValue ToSetValue()
		{
			return new ISendBattleEvents_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600AECB RID: 44747 RVA: 0x00189F4D File Offset: 0x0018814D
		// (set) Token: 0x0600AECC RID: 44748 RVA: 0x00189F78 File Offset: 0x00188178
		public override EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600AECD RID: 44749 RVA: 0x00189F88 File Offset: 0x00188188
		// (set) Token: 0x0600AECE RID: 44750 RVA: 0x0018A01B File Offset: 0x0018821B
		public virtual List<ISetBattleTagConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISetBattleTagConfig> configs = this.FbInstance.Configs;
					if (configs != null)
					{
						this._ConfigsCache = new List<ISetBattleTagConfig>(configs.Count);
						for (int i = 0; i < configs.Count; i++)
						{
							this._ConfigsCache.Add(ISetBattleTagConfig.Create(configs[i]));
						}
					}
				}
				else
				{
					ISendBattleEvents_SetValue pocoInterface = this.PocoInterface;
					this._ConfigsCache = ((pocoInterface != null) ? pocoInterface.Configs : null);
				}
				return this._ConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().Configs = value;
				this._ConfigsInited = false;
			}
		}

		// Token: 0x04006823 RID: 26659
		[Nullable(2)]
		protected new ISendBattleEvents FbInstance;

		// Token: 0x04006824 RID: 26660
		[Nullable(2)]
		protected new ISendBattleEvents_SetValue PocoInterface;

		// Token: 0x04006825 RID: 26661
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x04006826 RID: 26662
		private bool _ConfigsInited;
	}
}
