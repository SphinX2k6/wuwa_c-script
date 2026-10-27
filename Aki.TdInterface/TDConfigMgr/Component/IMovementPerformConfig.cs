using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000536 RID: 1334
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovementPerformConfig
	{
		// Token: 0x06001B42 RID: 6978 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		private IMovementPerformConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovementPerformConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovementPerformConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovementPerformConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0004EEF4 File Offset: 0x0004D0F4
		public static IMovementPerformConfig Create([Nullable(2)] IMovementPerformConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPerformConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0004EF07 File Offset: 0x0004D107
		public static IMovementPerformConfig CreateFromSetValue([Nullable(2)] IMovementPerformConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovementPerformConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0004EF1A File Offset: 0x0004D11A
		public IMovementPerformConfig_SetValue ToSetValue()
		{
			return new IMovementPerformConfig_SetValue
			{
				VehicleMontagePlayConfigs = this.VehicleMontagePlayConfigs,
				PlayerSpeedEffectConfigs = this.PlayerSpeedEffectConfigs
			};
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0004EF3C File Offset: 0x0004D13C
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0004EFCF File Offset: 0x0004D1CF
		public virtual List<IVehicleMontagePlayConfig> VehicleMontagePlayConfigs
		{
			get
			{
				if (this._VehicleMontagePlayConfigsInited)
				{
					return this._VehicleMontagePlayConfigsCache;
				}
				this._VehicleMontagePlayConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IVehicleMontagePlayConfig> vehicleMontagePlayConfigs = this.FbInstance.VehicleMontagePlayConfigs;
					if (vehicleMontagePlayConfigs != null)
					{
						this._VehicleMontagePlayConfigsCache = new List<IVehicleMontagePlayConfig>(vehicleMontagePlayConfigs.Count);
						for (int i = 0; i < vehicleMontagePlayConfigs.Count; i++)
						{
							this._VehicleMontagePlayConfigsCache.Add(IVehicleMontagePlayConfig.Create(vehicleMontagePlayConfigs[i]));
						}
					}
				}
				else
				{
					IMovementPerformConfig_SetValue pocoInterface = this.PocoInterface;
					this._VehicleMontagePlayConfigsCache = ((pocoInterface != null) ? pocoInterface.VehicleMontagePlayConfigs : null);
				}
				return this._VehicleMontagePlayConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().VehicleMontagePlayConfigs = value;
				this._VehicleMontagePlayConfigsInited = false;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0004EFE4 File Offset: 0x0004D1E4
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0004F077 File Offset: 0x0004D277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ISpeedEffectConfig> PlayerSpeedEffectConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._PlayerSpeedEffectConfigsInited)
				{
					return this._PlayerSpeedEffectConfigsCache;
				}
				this._PlayerSpeedEffectConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISpeedEffectConfig> playerSpeedEffectConfigs = this.FbInstance.PlayerSpeedEffectConfigs;
					if (playerSpeedEffectConfigs != null)
					{
						this._PlayerSpeedEffectConfigsCache = new List<ISpeedEffectConfig>(playerSpeedEffectConfigs.Count);
						for (int i = 0; i < playerSpeedEffectConfigs.Count; i++)
						{
							this._PlayerSpeedEffectConfigsCache.Add(ISpeedEffectConfig.Create(playerSpeedEffectConfigs[i]));
						}
					}
				}
				else
				{
					IMovementPerformConfig_SetValue pocoInterface = this.PocoInterface;
					this._PlayerSpeedEffectConfigsCache = ((pocoInterface != null) ? pocoInterface.PlayerSpeedEffectConfigs : null);
				}
				return this._PlayerSpeedEffectConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().PlayerSpeedEffectConfigs = value;
				this._PlayerSpeedEffectConfigsInited = false;
			}
		}

		// Token: 0x040013A5 RID: 5029
		[Nullable(2)]
		protected IMovementPerformConfig FbInstance;

		// Token: 0x040013A6 RID: 5030
		[Nullable(2)]
		protected IMovementPerformConfig_SetValue PocoInterface;

		// Token: 0x040013A7 RID: 5031
		private List<IVehicleMontagePlayConfig> _VehicleMontagePlayConfigsCache;

		// Token: 0x040013A8 RID: 5032
		private bool _VehicleMontagePlayConfigsInited;

		// Token: 0x040013A9 RID: 5033
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISpeedEffectConfig> _PlayerSpeedEffectConfigsCache;

		// Token: 0x040013AA RID: 5034
		private bool _PlayerSpeedEffectConfigsInited;
	}
}
