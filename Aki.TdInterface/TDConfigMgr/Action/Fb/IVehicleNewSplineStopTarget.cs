using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A01 RID: 10753
	public class IVehicleNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600EDBC RID: 60860 RVA: 0x0022EF51 File Offset: 0x0022D151
		public static IVehicleNewSplineStopTarget Create(IVehicleNewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x0600EDBD RID: 60861 RVA: 0x0022EF70 File Offset: 0x0022D170
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x0600EDBE RID: 60862 RVA: 0x0022EF7D File Offset: 0x0022D17D
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this._TargetVehicleInited)
				{
					return this._TargetVehicleCache;
				}
				this._TargetVehicleInited = true;
				this._TargetVehicleCache = ActionReadHelper.ReadIVehicleNewSplineStopTarget_TargetVehicle(this.Instance);
				return this._TargetVehicleCache;
			}
		}

		// Token: 0x040082CF RID: 33487
		private IVehicleNewSplineStopTarget Instance;

		// Token: 0x040082D0 RID: 33488
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x040082D1 RID: 33489
		private bool _TargetVehicleInited;
	}
}
