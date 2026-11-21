using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017AF RID: 6063
	public class EnableLevelPlay : ActionParams
	{
		// Token: 0x06008347 RID: 33607 RVA: 0x0013A31C File Offset: 0x0013851C
		private EnableLevelPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableLevelPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableLevelPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableLevelPlay_SetValue());
			}
			return result;
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x0013A354 File Offset: 0x00138554
		public static EnableLevelPlay Create([Nullable(2)] EnableLevelPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableLevelPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008349 RID: 33609 RVA: 0x0013A367 File Offset: 0x00138567
		public static EnableLevelPlay CreateFromSetValue([Nullable(2)] EnableLevelPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableLevelPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600834A RID: 33610 RVA: 0x0013A37A File Offset: 0x0013857A
		public EnableLevelPlay_SetValue ToSetValue()
		{
			return new EnableLevelPlay_SetValue
			{
				Configs = this.Configs,
				TargetPlayer = this.TargetPlayer
			};
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x0013A39C File Offset: 0x0013859C
		// (set) Token: 0x0600834C RID: 33612 RVA: 0x0013A42F File Offset: 0x0013862F
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
					EnableLevelPlay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600834D RID: 33613 RVA: 0x0013A444 File Offset: 0x00138644
		// (set) Token: 0x0600834E RID: 33614 RVA: 0x0013A47E File Offset: 0x0013867E
		public virtual EPlayerType? TargetPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPlayer;
				}
				EnableLevelPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetPlayer;
			}
			set
			{
				this.GetOrCreatePoco().TargetPlayer = value;
			}
		}

		// Token: 0x0400505E RID: 20574
		[Nullable(2)]
		protected new EnableLevelPlay FbInstance;

		// Token: 0x0400505F RID: 20575
		[Nullable(2)]
		protected EnableLevelPlay_SetValue PocoInterface;

		// Token: 0x04005060 RID: 20576
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x04005061 RID: 20577
		private bool _ConfigsInited;
	}
}
