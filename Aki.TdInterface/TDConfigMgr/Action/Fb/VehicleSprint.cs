using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D8 RID: 10712
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleSprint : ActionParams
	{
		// Token: 0x0600ECB3 RID: 60595 RVA: 0x00228E46 File Offset: 0x00227046
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

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x0600ECB4 RID: 60596 RVA: 0x00228E65 File Offset: 0x00227065
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

		// Token: 0x0400825A RID: 33370
		private IVehicleSprint Instance;

		// Token: 0x0400825B RID: 33371
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x0400825C RID: 33372
		private bool _TargetVehicleInited;
	}
}
