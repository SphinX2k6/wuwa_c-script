using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BF RID: 1983
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehiclePassengerConfig
	{
		// Token: 0x06002B05 RID: 11013 RVA: 0x0007073C File Offset: 0x0006E93C
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

		// Token: 0x06002B06 RID: 11014 RVA: 0x00070774 File Offset: 0x0006E974
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

		// Token: 0x06002B07 RID: 11015 RVA: 0x00070787 File Offset: 0x0006E987
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

		// Token: 0x06002B08 RID: 11016 RVA: 0x0007079A File Offset: 0x0006E99A
		public IVehiclePassengerConfig_SetValue ToSetValue()
		{
			return new IVehiclePassengerConfig_SetValue
			{
				PassengerNpc = this.PassengerNpc,
				Seat = this.Seat
			};
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000707B9 File Offset: 0x0006E9B9
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000707E4 File Offset: 0x0006E9E4
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000707F2 File Offset: 0x0006E9F2
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x0007081D File Offset: 0x0006EA1D
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

		// Token: 0x04001C9D RID: 7325
		[Nullable(2)]
		protected IVehiclePassengerConfig FbInstance;

		// Token: 0x04001C9E RID: 7326
		[Nullable(2)]
		protected IVehiclePassengerConfig_SetValue PocoInterface;
	}
}
