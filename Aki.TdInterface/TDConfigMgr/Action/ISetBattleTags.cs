using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002049 RID: 8265
	public class ISetBattleTags : IExecBattleActionType
	{
		// Token: 0x0600AF6D RID: 44909 RVA: 0x0018B2F0 File Offset: 0x001894F0
		private ISetBattleTags_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBattleTags 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBattleTags_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBattleTags_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF6E RID: 44910 RVA: 0x0018B328 File Offset: 0x00189528
		public static ISetBattleTags Create([Nullable(2)] ISetBattleTags instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTags
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF6F RID: 44911 RVA: 0x0018B33B File Offset: 0x0018953B
		public static ISetBattleTags CreateFromSetValue([Nullable(2)] ISetBattleTags_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBattleTags
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x0018B34E File Offset: 0x0018954E
		public new ISetBattleTags_SetValue ToSetValue()
		{
			return new ISetBattleTags_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600AF71 RID: 44913 RVA: 0x0018B36D File Offset: 0x0018956D
		// (set) Token: 0x0600AF72 RID: 44914 RVA: 0x0018B398 File Offset: 0x00189598
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

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600AF73 RID: 44915 RVA: 0x0018B3A8 File Offset: 0x001895A8
		// (set) Token: 0x0600AF74 RID: 44916 RVA: 0x0018B43B File Offset: 0x0018963B
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
					ISetBattleTags_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006876 RID: 26742
		[Nullable(2)]
		protected new ISetBattleTags FbInstance;

		// Token: 0x04006877 RID: 26743
		[Nullable(2)]
		protected new ISetBattleTags_SetValue PocoInterface;

		// Token: 0x04006878 RID: 26744
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x04006879 RID: 26745
		private bool _ConfigsInited;
	}
}
