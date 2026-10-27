using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002191 RID: 8593
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerForceEnableLevelPlay : ActionParams
	{
		// Token: 0x0600BCC6 RID: 48326 RVA: 0x001B2FF8 File Offset: 0x001B11F8
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

		// Token: 0x0600BCC7 RID: 48327 RVA: 0x001B3030 File Offset: 0x001B1230
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

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x001B3043 File Offset: 0x001B1243
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

		// Token: 0x0600BCC9 RID: 48329 RVA: 0x001B3056 File Offset: 0x001B1256
		public ServerForceEnableLevelPlay_SetValue ToSetValue()
		{
			return new ServerForceEnableLevelPlay_SetValue
			{
				Configs = this.Configs
			};
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600BCCA RID: 48330 RVA: 0x001B306C File Offset: 0x001B126C
		// (set) Token: 0x0600BCCB RID: 48331 RVA: 0x001B30FF File Offset: 0x001B12FF
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

		// Token: 0x040070AF RID: 28847
		[Nullable(2)]
		protected new ServerForceEnableLevelPlay FbInstance;

		// Token: 0x040070B0 RID: 28848
		[Nullable(2)]
		protected ServerForceEnableLevelPlay_SetValue PocoInterface;

		// Token: 0x040070B1 RID: 28849
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x040070B2 RID: 28850
		private bool _ConfigsInited;
	}
}
