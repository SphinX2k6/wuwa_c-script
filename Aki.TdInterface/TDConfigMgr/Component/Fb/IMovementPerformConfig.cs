using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3F RID: 3647
	public class IMovementPerformConfig
	{
		// Token: 0x06005295 RID: 21141 RVA: 0x000CC248 File Offset: 0x000CA448
		public static IMovementPerformConfig Create(IMovementPerformConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPerformConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06005296 RID: 21142 RVA: 0x000CC268 File Offset: 0x000CA468
		public virtual List<IVehicleMontagePlayConfig> VehicleMontagePlayConfigs
		{
			get
			{
				if (this._VehicleMontagePlayConfigsInited)
				{
					return this._VehicleMontagePlayConfigsCache;
				}
				this._VehicleMontagePlayConfigsInited = true;
				int vehicleMontagePlayConfigsLength = this.Instance.VehicleMontagePlayConfigsLength;
				this._VehicleMontagePlayConfigsCache = new List<IVehicleMontagePlayConfig>(vehicleMontagePlayConfigsLength);
				for (int i = 0; i < vehicleMontagePlayConfigsLength; i++)
				{
					this._VehicleMontagePlayConfigsCache.Add(IVehicleMontagePlayConfig.Create(this.Instance.VehicleMontagePlayConfigs(i)));
				}
				return this._VehicleMontagePlayConfigsCache;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x000CC2D4 File Offset: 0x000CA4D4
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int playerSpeedEffectConfigsLength = this.Instance.PlayerSpeedEffectConfigsLength;
				this._PlayerSpeedEffectConfigsCache = new List<ISpeedEffectConfig>(playerSpeedEffectConfigsLength);
				for (int i = 0; i < playerSpeedEffectConfigsLength; i++)
				{
					this._PlayerSpeedEffectConfigsCache.Add(ISpeedEffectConfig.Create(this.Instance.PlayerSpeedEffectConfigs(i)));
				}
				return this._PlayerSpeedEffectConfigsCache;
			}
		}

		// Token: 0x04002F28 RID: 12072
		private IMovementPerformConfig Instance;

		// Token: 0x04002F29 RID: 12073
		private List<IVehicleMontagePlayConfig> _VehicleMontagePlayConfigsCache;

		// Token: 0x04002F2A RID: 12074
		private bool _VehicleMontagePlayConfigsInited;

		// Token: 0x04002F2B RID: 12075
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ISpeedEffectConfig> _PlayerSpeedEffectConfigsCache;

		// Token: 0x04002F2C RID: 12076
		private bool _PlayerSpeedEffectConfigsInited;
	}
}
