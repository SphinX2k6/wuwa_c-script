using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024E0 RID: 9440
	public class VehicleMoveWithPathLine : ActionParams
	{
		// Token: 0x0600CD40 RID: 52544 RVA: 0x001D372C File Offset: 0x001D192C
		private VehicleMoveWithPathLine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleMoveWithPathLine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleMoveWithPathLine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleMoveWithPathLine_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD41 RID: 52545 RVA: 0x001D3764 File Offset: 0x001D1964
		public static VehicleMoveWithPathLine Create([Nullable(2)] VehicleMoveWithPathLine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleMoveWithPathLine
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD42 RID: 52546 RVA: 0x001D3777 File Offset: 0x001D1977
		public static VehicleMoveWithPathLine CreateFromSetValue([Nullable(2)] VehicleMoveWithPathLine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleMoveWithPathLine
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD43 RID: 52547 RVA: 0x001D378A File Offset: 0x001D198A
		public VehicleMoveWithPathLine_SetValue ToSetValue()
		{
			return new VehicleMoveWithPathLine_SetValue
			{
				TargetVehicle = this.TargetVehicle,
				SplineEntityId = this.SplineEntityId,
				ControlType = this.ControlType
			};
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600CD44 RID: 52548 RVA: 0x001D37B5 File Offset: 0x001D19B5
		// (set) Token: 0x0600CD45 RID: 52549 RVA: 0x001D37DC File Offset: 0x001D19DC
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				VehicleMoveWithPathLine_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetVehicle;
			}
			set
			{
				this.GetOrCreatePoco().TargetVehicle = value;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x001D37EA File Offset: 0x001D19EA
		// (set) Token: 0x0600CD47 RID: 52551 RVA: 0x001D3815 File Offset: 0x001D1A15
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600CD48 RID: 52552 RVA: 0x001D3823 File Offset: 0x001D1A23
		// (set) Token: 0x0600CD49 RID: 52553 RVA: 0x001D384A File Offset: 0x001D1A4A
		public virtual IVehicleControlType ControlType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ControlType;
				}
				VehicleMoveWithPathLine_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ControlType;
			}
			set
			{
				this.GetOrCreatePoco().ControlType = value;
			}
		}

		// Token: 0x04007990 RID: 31120
		[Nullable(2)]
		protected new VehicleMoveWithPathLine FbInstance;

		// Token: 0x04007991 RID: 31121
		[Nullable(2)]
		protected VehicleMoveWithPathLine_SetValue PocoInterface;
	}
}
