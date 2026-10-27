using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002043 RID: 8259
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600B582 RID: 46466 RVA: 0x001A56DC File Offset: 0x001A38DC
		private IVehicleNewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleNewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleNewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleNewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x001A5714 File Offset: 0x001A3914
		public static IVehicleNewSplineStopTarget Create([Nullable(2)] IVehicleNewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x001A5727 File Offset: 0x001A3927
		public static IVehicleNewSplineStopTarget CreateFromSetValue([Nullable(2)] IVehicleNewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleNewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x001A573A File Offset: 0x001A393A
		public new IVehicleNewSplineStopTarget_SetValue ToSetValue()
		{
			return new IVehicleNewSplineStopTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600B586 RID: 46470 RVA: 0x001A5759 File Offset: 0x001A3959
		// (set) Token: 0x0600B587 RID: 46471 RVA: 0x001A5784 File Offset: 0x001A3984
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600B588 RID: 46472 RVA: 0x001A5792 File Offset: 0x001A3992
		// (set) Token: 0x0600B589 RID: 46473 RVA: 0x001A57B9 File Offset: 0x001A39B9
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleNewSplineStopTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006D34 RID: 27956
		[Nullable(2)]
		protected new IVehicleNewSplineStopTarget FbInstance;

		// Token: 0x04006D35 RID: 27957
		[Nullable(2)]
		protected new IVehicleNewSplineStopTarget_SetValue PocoInterface;
	}
}
