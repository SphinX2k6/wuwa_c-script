using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002035 RID: 8245
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEnteringNpcTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600B536 RID: 46390 RVA: 0x001A4E9C File Offset: 0x001A309C
		private IVehicleEnteringNpcTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEnteringNpcTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEnteringNpcTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEnteringNpcTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x001A4ED4 File Offset: 0x001A30D4
		public static IVehicleEnteringNpcTarget Create([Nullable(2)] IVehicleEnteringNpcTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringNpcTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x001A4EE7 File Offset: 0x001A30E7
		public static IVehicleEnteringNpcTarget CreateFromSetValue([Nullable(2)] IVehicleEnteringNpcTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEnteringNpcTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x001A4EFA File Offset: 0x001A30FA
		public new IVehicleEnteringNpcTarget_SetValue ToSetValue()
		{
			return new IVehicleEnteringNpcTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle,
				TargetNpc = this.TargetNpc
			};
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600B53A RID: 46394 RVA: 0x001A4F25 File Offset: 0x001A3125
		// (set) Token: 0x0600B53B RID: 46395 RVA: 0x001A4F50 File Offset: 0x001A3150
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

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600B53C RID: 46396 RVA: 0x001A4F60 File Offset: 0x001A3160
		// (set) Token: 0x0600B53D RID: 46397 RVA: 0x001A4F9A File Offset: 0x001A319A
		public override int? TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleEnteringNpcTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600B53E RID: 46398 RVA: 0x001A4FA8 File Offset: 0x001A31A8
		// (set) Token: 0x0600B53F RID: 46399 RVA: 0x001A4FD3 File Offset: 0x001A31D3
		public virtual int TargetNpc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetNpc;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetNpc;
			}
			set
			{
				this.GetOrCreatePoco().TargetNpc = value;
			}
		}

		// Token: 0x04006D13 RID: 27923
		[Nullable(2)]
		protected new IVehicleEnteringNpcTarget FbInstance;

		// Token: 0x04006D14 RID: 27924
		[Nullable(2)]
		protected new IVehicleEnteringNpcTarget_SetValue PocoInterface;
	}
}
