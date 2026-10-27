using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203D RID: 8253
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEntity : ITargetEntityType
	{
		// Token: 0x0600B562 RID: 46434 RVA: 0x001A5394 File Offset: 0x001A3594
		private IVehicleEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x001A53CC File Offset: 0x001A35CC
		public static IVehicleEntity Create([Nullable(2)] IVehicleEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x001A53DF File Offset: 0x001A35DF
		public static IVehicleEntity CreateFromSetValue([Nullable(2)] IVehicleEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x001A53F2 File Offset: 0x001A35F2
		public new IVehicleEntity_SetValue ToSetValue()
		{
			return new IVehicleEntity_SetValue
			{
				Type = this.Type,
				Vehicle = this.Vehicle
			};
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x001A5411 File Offset: 0x001A3611
		// (set) Token: 0x0600B567 RID: 46439 RVA: 0x001A543C File Offset: 0x001A363C
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600B568 RID: 46440 RVA: 0x001A544A File Offset: 0x001A364A
		// (set) Token: 0x0600B569 RID: 46441 RVA: 0x001A5471 File Offset: 0x001A3671
		public virtual ITargetVehicle Vehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Vehicle;
				}
				IVehicleEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Vehicle;
			}
			set
			{
				this.GetOrCreatePoco().Vehicle = value;
			}
		}

		// Token: 0x04006D27 RID: 27943
		[Nullable(2)]
		protected new IVehicleEntity FbInstance;

		// Token: 0x04006D28 RID: 27944
		[Nullable(2)]
		protected new IVehicleEntity_SetValue PocoInterface;
	}
}
