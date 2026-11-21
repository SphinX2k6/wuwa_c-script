using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195D RID: 6493
	public class IAppointedVehicle : ITargetVehicle
	{
		// Token: 0x06008A15 RID: 35349 RVA: 0x00148798 File Offset: 0x00146998
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

		// Token: 0x06008A16 RID: 35350 RVA: 0x001487D0 File Offset: 0x001469D0
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

		// Token: 0x06008A17 RID: 35351 RVA: 0x001487E3 File Offset: 0x001469E3
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

		// Token: 0x06008A18 RID: 35352 RVA: 0x001487F6 File Offset: 0x001469F6
		public new IAppointedVehicle_SetValue ToSetValue()
		{
			return new IAppointedVehicle_SetValue
			{
				Type = this.Type,
				VehicleId = this.VehicleId
			};
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x06008A19 RID: 35353 RVA: 0x00148815 File Offset: 0x00146A15
		// (set) Token: 0x06008A1A RID: 35354 RVA: 0x00148840 File Offset: 0x00146A40
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

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x06008A1B RID: 35355 RVA: 0x0014884E File Offset: 0x00146A4E
		// (set) Token: 0x06008A1C RID: 35356 RVA: 0x00148879 File Offset: 0x00146A79
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

		// Token: 0x0400577C RID: 22396
		[Nullable(2)]
		protected new IAppointedVehicle FbInstance;

		// Token: 0x0400577D RID: 22397
		[Nullable(2)]
		protected new IAppointedVehicle_SetValue PocoInterface;
	}
}
