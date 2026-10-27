using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D6 RID: 6102
	[NullableContext(1)]
	[Nullable(0)]
	public class IAppointedVehicle : ITargetVehicle
	{
		// Token: 0x06008303 RID: 33539 RVA: 0x001391B0 File Offset: 0x001373B0
		private IAppointedVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAppointedVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAppointedVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAppointedVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x001391E8 File Offset: 0x001373E8
		public static IAppointedVehicle Create([Nullable(2)] IAppointedVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAppointedVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008305 RID: 33541 RVA: 0x001391FB File Offset: 0x001373FB
		public static IAppointedVehicle CreateFromSetValue([Nullable(2)] IAppointedVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAppointedVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x0013920E File Offset: 0x0013740E
		public new IAppointedVehicle_SetValue ToSetValue()
		{
			return new IAppointedVehicle_SetValue
			{
				Type = this.Type,
				VehicleId = this.VehicleId
			};
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x06008307 RID: 33543 RVA: 0x0013922D File Offset: 0x0013742D
		// (set) Token: 0x06008308 RID: 33544 RVA: 0x00139258 File Offset: 0x00137458
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x06008309 RID: 33545 RVA: 0x00139266 File Offset: 0x00137466
		// (set) Token: 0x0600830A RID: 33546 RVA: 0x00139291 File Offset: 0x00137491
		public virtual int VehicleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VehicleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VehicleId;
			}
			set
			{
				this.GetOrCreatePoco().VehicleId = value;
			}
		}

		// Token: 0x04005338 RID: 21304
		[Nullable(2)]
		protected new IAppointedVehicle FbInstance;

		// Token: 0x04005339 RID: 21305
		[Nullable(2)]
		protected new IAppointedVehicle_SetValue PocoInterface;
	}
}
