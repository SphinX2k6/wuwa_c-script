using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200059D RID: 1437
	public class IMovementPerformConfig
	{
		// Token: 0x06001D3E RID: 7486 RVA: 0x00053C78 File Offset: 0x00051E78
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

		// Token: 0x06001D3F RID: 7487 RVA: 0x00053CB0 File Offset: 0x00051EB0
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

		// Token: 0x06001D40 RID: 7488 RVA: 0x00053CC3 File Offset: 0x00051EC3
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

		// Token: 0x06001D41 RID: 7489 RVA: 0x00053CD6 File Offset: 0x00051ED6
		public IMovementPerformConfig_SetValue ToSetValue()
		{
			return new IMovementPerformConfig_SetValue
			{
				VehicleMontagePlayConfigs = this.VehicleMontagePlayConfigs,
				PlayerSpeedEffectConfigs = this.PlayerSpeedEffectConfigs
			};
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00053CF8 File Offset: 0x00051EF8
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00053D8B File Offset: 0x00051F8B
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

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00053DA0 File Offset: 0x00051FA0
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00053E33 File Offset: 0x00052033
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ISpeedEffectConfig> PlayerSpeedEffectConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().PlayerSpeedEffectConfigs = value;
				this._PlayerSpeedEffectConfigsInited = false;
			}
		}

		// Token: 0x0400150F RID: 5391
		[Nullable(2)]
		protected IMovementPerformConfig FbInstance;

		// Token: 0x04001510 RID: 5392
		[Nullable(2)]
		protected IMovementPerformConfig_SetValue PocoInterface;

		// Token: 0x04001511 RID: 5393
		private List<IVehicleMontagePlayConfig> _VehicleMontagePlayConfigsCache;

		// Token: 0x04001512 RID: 5394
		private bool _VehicleMontagePlayConfigsInited;

		// Token: 0x04001513 RID: 5395
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ISpeedEffectConfig> _PlayerSpeedEffectConfigsCache;

		// Token: 0x04001514 RID: 5396
		private bool _PlayerSpeedEffectConfigsInited;
	}
}
