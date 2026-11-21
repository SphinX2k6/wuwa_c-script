using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D9A RID: 11674
	public class VehicleSetSpeedImmediately : ActionParams
	{
		// Token: 0x0600FE72 RID: 65138 RVA: 0x0024B475 File Offset: 0x00249675
		public static VehicleSetSpeedImmediately Create(IVehicleSetSpeedImmediately? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSetSpeedImmediately
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x0600FE73 RID: 65139 RVA: 0x0024B494 File Offset: 0x00249694
		public virtual ISetVehicleSpeedImmediatelyType SetSpeedConfig
		{
			get
			{
				if (this._SetSpeedConfigInited)
				{
					return this._SetSpeedConfigCache;
				}
				this._SetSpeedConfigInited = true;
				this._SetSpeedConfigCache = ActionReadHelper.ReadVehicleSetSpeedImmediately_SetSpeedConfig(this.Instance);
				return this._SetSpeedConfigCache;
			}
		}

		// Token: 0x04008AE6 RID: 35558
		private IVehicleSetSpeedImmediately Instance;

		// Token: 0x04008AE7 RID: 35559
		private ISetVehicleSpeedImmediatelyType _SetSpeedConfigCache;

		// Token: 0x04008AE8 RID: 35560
		private bool _SetSpeedConfigInited;
	}
}
