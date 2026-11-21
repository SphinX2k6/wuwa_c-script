using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FA RID: 9210
	public class ServerForceEnableLevelPlay : ActionParams
	{
		// Token: 0x0600C876 RID: 51318 RVA: 0x001CA4F0 File Offset: 0x001C86F0
		private ServerForceEnableLevelPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ServerForceEnableLevelPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ServerForceEnableLevelPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ServerForceEnableLevelPlay_SetValue());
			}
			return result;
		}

		// Token: 0x0600C877 RID: 51319 RVA: 0x001CA528 File Offset: 0x001C8728
		public static ServerForceEnableLevelPlay Create([Nullable(2)] ServerForceEnableLevelPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ServerForceEnableLevelPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x001CA53B File Offset: 0x001C873B
		public static ServerForceEnableLevelPlay CreateFromSetValue([Nullable(2)] ServerForceEnableLevelPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ServerForceEnableLevelPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x001CA54E File Offset: 0x001C874E
		public ServerForceEnableLevelPlay_SetValue ToSetValue()
		{
			return new ServerForceEnableLevelPlay_SetValue
			{
				Configs = this.Configs
			};
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600C87A RID: 51322 RVA: 0x001CA564 File Offset: 0x001C8764
		// (set) Token: 0x0600C87B RID: 51323 RVA: 0x001CA5F7 File Offset: 0x001C87F7
		public virtual List<IEnableLevelPlayConfig> Configs
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
					List<IEnableLevelPlayConfig> configs = this.FbInstance.Configs;
					if (configs != null)
					{
						this._ConfigsCache = new List<IEnableLevelPlayConfig>(configs.Count);
						for (int i = 0; i < configs.Count; i++)
						{
							this._ConfigsCache.Add(IEnableLevelPlayConfig.Create(configs[i]));
						}
					}
				}
				else
				{
					ServerForceEnableLevelPlay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040076F1 RID: 30449
		[Nullable(2)]
		protected new ServerForceEnableLevelPlay FbInstance;

		// Token: 0x040076F2 RID: 30450
		[Nullable(2)]
		protected ServerForceEnableLevelPlay_SetValue PocoInterface;

		// Token: 0x040076F3 RID: 30451
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x040076F4 RID: 30452
		private bool _ConfigsInited;
	}
}
