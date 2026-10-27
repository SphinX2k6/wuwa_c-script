using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002273 RID: 8819
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleMoveWithPathLine : ActionParams
	{
		// Token: 0x0600C17A RID: 49530 RVA: 0x001BBFA8 File Offset: 0x001BA1A8
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

		// Token: 0x0600C17B RID: 49531 RVA: 0x001BBFE0 File Offset: 0x001BA1E0
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

		// Token: 0x0600C17C RID: 49532 RVA: 0x001BBFF3 File Offset: 0x001BA1F3
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

		// Token: 0x0600C17D RID: 49533 RVA: 0x001BC006 File Offset: 0x001BA206
		public VehicleMoveWithPathLine_SetValue ToSetValue()
		{
			return new VehicleMoveWithPathLine_SetValue
			{
				TargetVehicle = this.TargetVehicle,
				SplineEntityId = this.SplineEntityId,
				ControlType = this.ControlType
			};
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600C17E RID: 49534 RVA: 0x001BC031 File Offset: 0x001BA231
		// (set) Token: 0x0600C17F RID: 49535 RVA: 0x001BC058 File Offset: 0x001BA258
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

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600C180 RID: 49536 RVA: 0x001BC066 File Offset: 0x001BA266
		// (set) Token: 0x0600C181 RID: 49537 RVA: 0x001BC091 File Offset: 0x001BA291
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

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600C182 RID: 49538 RVA: 0x001BC09F File Offset: 0x001BA29F
		// (set) Token: 0x0600C183 RID: 49539 RVA: 0x001BC0C6 File Offset: 0x001BA2C6
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

		// Token: 0x04007343 RID: 29507
		[Nullable(2)]
		protected new VehicleMoveWithPathLine FbInstance;

		// Token: 0x04007344 RID: 29508
		[Nullable(2)]
		protected VehicleMoveWithPathLine_SetValue PocoInterface;
	}
}
