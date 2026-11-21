using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC4 RID: 11460
	public class VehicleMoveWithPathLine : ActionParams
	{
		// Token: 0x0600FB45 RID: 64325 RVA: 0x00246738 File Offset: 0x00244938
		public static VehicleMoveWithPathLine Create(IVehicleMoveWithPathLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleMoveWithPathLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x0600FB46 RID: 64326 RVA: 0x00246757 File Offset: 0x00244957
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this._TargetVehicleInited)
				{
					return this._TargetVehicleCache;
				}
				this._TargetVehicleInited = true;
				this._TargetVehicleCache = ActionReadHelper.ReadVehicleMoveWithPathLine_TargetVehicle(this.Instance);
				return this._TargetVehicleCache;
			}
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x0600FB47 RID: 64327 RVA: 0x00246786 File Offset: 0x00244986
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x0600FB48 RID: 64328 RVA: 0x00246793 File Offset: 0x00244993
		public virtual IVehicleControlType ControlType
		{
			get
			{
				if (this._ControlTypeInited)
				{
					return this._ControlTypeCache;
				}
				this._ControlTypeInited = true;
				this._ControlTypeCache = ActionReadHelper.ReadVehicleMoveWithPathLine_ControlType(this.Instance);
				return this._ControlTypeCache;
			}
		}

		// Token: 0x04008946 RID: 35142
		private IVehicleMoveWithPathLine Instance;

		// Token: 0x04008947 RID: 35143
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x04008948 RID: 35144
		private bool _TargetVehicleInited;

		// Token: 0x04008949 RID: 35145
		private IVehicleControlType _ControlTypeCache;

		// Token: 0x0400894A RID: 35146
		private bool _ControlTypeInited;
	}
}
