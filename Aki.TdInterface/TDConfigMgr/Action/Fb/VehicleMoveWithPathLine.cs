using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D7 RID: 10711
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleMoveWithPathLine : ActionParams
	{
		// Token: 0x0600ECAE RID: 60590 RVA: 0x00228DB4 File Offset: 0x00226FB4
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

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x0600ECAF RID: 60591 RVA: 0x00228DD3 File Offset: 0x00226FD3
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

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x0600ECB0 RID: 60592 RVA: 0x00228E02 File Offset: 0x00227002
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x00228E0F File Offset: 0x0022700F
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

		// Token: 0x04008255 RID: 33365
		private IVehicleMoveWithPathLine Instance;

		// Token: 0x04008256 RID: 33366
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x04008257 RID: 33367
		private bool _TargetVehicleInited;

		// Token: 0x04008258 RID: 33368
		private IVehicleControlType _ControlTypeCache;

		// Token: 0x04008259 RID: 33369
		private bool _ControlTypeInited;
	}
}
