using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E16 RID: 7702
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBattleTags : IExecBattleActionType
	{
		// Token: 0x0600A4C5 RID: 42181 RVA: 0x001758E8 File Offset: 0x00173AE8
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

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x00175920 File Offset: 0x00173B20
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

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x00175933 File Offset: 0x00173B33
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

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x00175946 File Offset: 0x00173B46
		public new ISetBattleTags_SetValue ToSetValue()
		{
			return new ISetBattleTags_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A4C9 RID: 42185 RVA: 0x00175965 File Offset: 0x00173B65
		// (set) Token: 0x0600A4CA RID: 42186 RVA: 0x00175990 File Offset: 0x00173B90
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

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A4CB RID: 42187 RVA: 0x001759A0 File Offset: 0x00173BA0
		// (set) Token: 0x0600A4CC RID: 42188 RVA: 0x00175A33 File Offset: 0x00173C33
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

		// Token: 0x0400629F RID: 25247
		[Nullable(2)]
		protected new ISetBattleTags FbInstance;

		// Token: 0x040062A0 RID: 25248
		[Nullable(2)]
		protected new ISetBattleTags_SetValue PocoInterface;

		// Token: 0x040062A1 RID: 25249
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x040062A2 RID: 25250
		private bool _ConfigsInited;
	}
}
