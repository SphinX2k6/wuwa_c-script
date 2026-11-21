using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC5 RID: 11461
	public class VehicleSprint : ActionParams
	{
		// Token: 0x0600FB4A RID: 64330 RVA: 0x002467CA File Offset: 0x002449CA
		public static VehicleSprint Create(IVehicleSprint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSprint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x0600FB4B RID: 64331 RVA: 0x002467E9 File Offset: 0x002449E9
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this._TargetVehicleInited)
				{
					return this._TargetVehicleCache;
				}
				this._TargetVehicleInited = true;
				this._TargetVehicleCache = ActionReadHelper.ReadVehicleSprint_TargetVehicle(this.Instance);
				return this._TargetVehicleCache;
			}
		}

		// Token: 0x0400894B RID: 35147
		private IVehicleSprint Instance;

		// Token: 0x0400894C RID: 35148
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x0400894D RID: 35149
		private bool _TargetVehicleInited;
	}
}
