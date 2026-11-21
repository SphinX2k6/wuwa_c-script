using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024E6 RID: 9446
	public class VehicleSprint : ActionParams
	{
		// Token: 0x0600CD60 RID: 52576 RVA: 0x001D3AA0 File Offset: 0x001D1CA0
		private VehicleSprint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleSprint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleSprint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleSprint_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD61 RID: 52577 RVA: 0x001D3AD8 File Offset: 0x001D1CD8
		public static VehicleSprint Create([Nullable(2)] VehicleSprint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSprint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD62 RID: 52578 RVA: 0x001D3AEB File Offset: 0x001D1CEB
		public static VehicleSprint CreateFromSetValue([Nullable(2)] VehicleSprint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleSprint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD63 RID: 52579 RVA: 0x001D3AFE File Offset: 0x001D1CFE
		public VehicleSprint_SetValue ToSetValue()
		{
			return new VehicleSprint_SetValue
			{
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x001D3B11 File Offset: 0x001D1D11
		// (set) Token: 0x0600CD65 RID: 52581 RVA: 0x001D3B38 File Offset: 0x001D1D38
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				VehicleSprint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400799F RID: 31135
		[Nullable(2)]
		protected new VehicleSprint FbInstance;

		// Token: 0x040079A0 RID: 31136
		[Nullable(2)]
		protected VehicleSprint_SetValue PocoInterface;
	}
}
