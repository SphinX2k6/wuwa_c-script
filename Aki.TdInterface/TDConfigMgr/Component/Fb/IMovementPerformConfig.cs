using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D45 RID: 3397
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovementPerformConfig
	{
		// Token: 0x06004D79 RID: 19833 RVA: 0x000C0B04 File Offset: 0x000BED04
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

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x000C0B24 File Offset: 0x000BED24
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

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06004D7B RID: 19835 RVA: 0x000C0B90 File Offset: 0x000BED90
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

		// Token: 0x04002C68 RID: 11368
		private IMovementPerformConfig Instance;

		// Token: 0x04002C69 RID: 11369
		private List<IVehicleMontagePlayConfig> _VehicleMontagePlayConfigsCache;

		// Token: 0x04002C6A RID: 11370
		private bool _VehicleMontagePlayConfigsInited;

		// Token: 0x04002C6B RID: 11371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISpeedEffectConfig> _PlayerSpeedEffectConfigsCache;

		// Token: 0x04002C6C RID: 11372
		private bool _PlayerSpeedEffectConfigsInited;
	}
}
