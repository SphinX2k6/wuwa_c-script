using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000862 RID: 2146
	public class IVehiclePassengerConfig
	{
		// Token: 0x06002E35 RID: 11829 RVA: 0x00077AA0 File Offset: 0x00075CA0
		private IVehiclePassengerConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehiclePassengerConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehiclePassengerConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehiclePassengerConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00077AD8 File Offset: 0x00075CD8
		public static IVehiclePassengerConfig Create([Nullable(2)] IVehiclePassengerConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehiclePassengerConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00077AEB File Offset: 0x00075CEB
		public static IVehiclePassengerConfig CreateFromSetValue([Nullable(2)] IVehiclePassengerConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehiclePassengerConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00077AFE File Offset: 0x00075CFE
		public IVehiclePassengerConfig_SetValue ToSetValue()
		{
			return new IVehiclePassengerConfig_SetValue
			{
				PassengerNpc = this.PassengerNpc,
				Seat = this.Seat
			};
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00077B1D File Offset: 0x00075D1D
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00077B48 File Offset: 0x00075D48
		public virtual int PassengerNpc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PassengerNpc;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PassengerNpc;
			}
			set
			{
				this.GetOrCreatePoco().PassengerNpc = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00077B56 File Offset: 0x00075D56
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00077B81 File Offset: 0x00075D81
		public virtual int Seat
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Seat;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Seat;
			}
			set
			{
				this.GetOrCreatePoco().Seat = value;
			}
		}

		// Token: 0x04001EA9 RID: 7849
		[Nullable(2)]
		protected IVehiclePassengerConfig FbInstance;

		// Token: 0x04001EAA RID: 7850
		[Nullable(2)]
		protected IVehiclePassengerConfig_SetValue PocoInterface;
	}
}
