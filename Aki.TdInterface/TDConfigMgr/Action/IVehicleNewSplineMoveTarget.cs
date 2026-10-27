using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002041 RID: 8257
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600B576 RID: 46454 RVA: 0x001A558C File Offset: 0x001A378C
		private IVehicleNewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleNewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleNewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleNewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600B577 RID: 46455 RVA: 0x001A55C4 File Offset: 0x001A37C4
		public static IVehicleNewSplineMoveTarget Create([Nullable(2)] IVehicleNewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B578 RID: 46456 RVA: 0x001A55D7 File Offset: 0x001A37D7
		public static IVehicleNewSplineMoveTarget CreateFromSetValue([Nullable(2)] IVehicleNewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleNewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B579 RID: 46457 RVA: 0x001A55EA File Offset: 0x001A37EA
		public new IVehicleNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new IVehicleNewSplineMoveTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle,
				IsLookDir = this.IsLookDir
			};
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B57A RID: 46458 RVA: 0x001A5615 File Offset: 0x001A3815
		// (set) Token: 0x0600B57B RID: 46459 RVA: 0x001A5640 File Offset: 0x001A3840
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

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B57C RID: 46460 RVA: 0x001A564E File Offset: 0x001A384E
		// (set) Token: 0x0600B57D RID: 46461 RVA: 0x001A5675 File Offset: 0x001A3875
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleNewSplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B57E RID: 46462 RVA: 0x001A5684 File Offset: 0x001A3884
		// (set) Token: 0x0600B57F RID: 46463 RVA: 0x001A56BE File Offset: 0x001A38BE
		public virtual bool? IsLookDir
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLookDir;
				}
				IVehicleNewSplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLookDir;
			}
			set
			{
				this.GetOrCreatePoco().IsLookDir = value;
			}
		}

		// Token: 0x04006D2F RID: 27951
		[Nullable(2)]
		protected new IVehicleNewSplineMoveTarget FbInstance;

		// Token: 0x04006D30 RID: 27952
		[Nullable(2)]
		protected new IVehicleNewSplineMoveTarget_SetValue PocoInterface;
	}
}
