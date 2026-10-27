using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002037 RID: 8247
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEnteringPlayerTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600B542 RID: 46402 RVA: 0x001A4FF4 File Offset: 0x001A31F4
		private IVehicleEnteringPlayerTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEnteringPlayerTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEnteringPlayerTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEnteringPlayerTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x001A502C File Offset: 0x001A322C
		public static IVehicleEnteringPlayerTarget Create([Nullable(2)] IVehicleEnteringPlayerTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringPlayerTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x001A503F File Offset: 0x001A323F
		public static IVehicleEnteringPlayerTarget CreateFromSetValue([Nullable(2)] IVehicleEnteringPlayerTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEnteringPlayerTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x001A5052 File Offset: 0x001A3252
		public new IVehicleEnteringPlayerTarget_SetValue ToSetValue()
		{
			return new IVehicleEnteringPlayerTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600B546 RID: 46406 RVA: 0x001A5071 File Offset: 0x001A3271
		// (set) Token: 0x0600B547 RID: 46407 RVA: 0x001A509C File Offset: 0x001A329C
		public override EVehicleEnteringTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleEnteringTarget.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600B548 RID: 46408 RVA: 0x001A50AC File Offset: 0x001A32AC
		// (set) Token: 0x0600B549 RID: 46409 RVA: 0x001A50E6 File Offset: 0x001A32E6
		public override int? TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleEnteringPlayerTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006D18 RID: 27928
		[Nullable(2)]
		protected new IVehicleEnteringPlayerTarget FbInstance;

		// Token: 0x04006D19 RID: 27929
		[Nullable(2)]
		protected new IVehicleEnteringPlayerTarget_SetValue PocoInterface;
	}
}
