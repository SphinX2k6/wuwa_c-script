using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001642 RID: 5698
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableLevelPlay : ActionParams
	{
		// Token: 0x06007C69 RID: 31849 RVA: 0x0012B270 File Offset: 0x00129470
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

		// Token: 0x06007C6A RID: 31850 RVA: 0x0012B2A8 File Offset: 0x001294A8
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

		// Token: 0x06007C6B RID: 31851 RVA: 0x0012B2BB File Offset: 0x001294BB
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

		// Token: 0x06007C6C RID: 31852 RVA: 0x0012B2CE File Offset: 0x001294CE
		public EnableLevelPlay_SetValue ToSetValue()
		{
			return new EnableLevelPlay_SetValue
			{
				Configs = this.Configs,
				TargetPlayer = this.TargetPlayer
			};
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06007C6D RID: 31853 RVA: 0x0012B2F0 File Offset: 0x001294F0
		// (set) Token: 0x06007C6E RID: 31854 RVA: 0x0012B383 File Offset: 0x00129583
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

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x0012B398 File Offset: 0x00129598
		// (set) Token: 0x06007C70 RID: 31856 RVA: 0x0012B3D2 File Offset: 0x001295D2
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

		// Token: 0x04004C6A RID: 19562
		[Nullable(2)]
		protected new EnableLevelPlay FbInstance;

		// Token: 0x04004C6B RID: 19563
		[Nullable(2)]
		protected EnableLevelPlay_SetValue PocoInterface;

		// Token: 0x04004C6C RID: 19564
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x04004C6D RID: 19565
		private bool _ConfigsInited;
	}
}
