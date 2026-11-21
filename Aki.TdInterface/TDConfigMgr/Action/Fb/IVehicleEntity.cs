using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A91 RID: 10897
	public class IVehicleEntity : ITargetEntityType
	{
		// Token: 0x0600F072 RID: 61554 RVA: 0x00233BA6 File Offset: 0x00231DA6
		public static IVehicleEntity Create(IVehicleEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x0600F073 RID: 61555 RVA: 0x00233BC5 File Offset: 0x00231DC5
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x0600F074 RID: 61556 RVA: 0x00233BD2 File Offset: 0x00231DD2
		public virtual ITargetVehicle Vehicle
		{
			get
			{
				if (this._VehicleInited)
				{
					return this._VehicleCache;
				}
				this._VehicleInited = true;
				this._VehicleCache = ActionReadHelper.ReadIVehicleEntity_Vehicle(this.Instance);
				return this._VehicleCache;
			}
		}

		// Token: 0x04008435 RID: 33845
		private IVehicleEntity Instance;

		// Token: 0x04008436 RID: 33846
		private ITargetVehicle _VehicleCache;

		// Token: 0x04008437 RID: 33847
		private bool _VehicleInited;
	}
}
