using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228A RID: 8842
	public class IVehicleNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600C09C RID: 49308 RVA: 0x001BBCF8 File Offset: 0x001B9EF8
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

		// Token: 0x0600C09D RID: 49309 RVA: 0x001BBD30 File Offset: 0x001B9F30
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

		// Token: 0x0600C09E RID: 49310 RVA: 0x001BBD43 File Offset: 0x001B9F43
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

		// Token: 0x0600C09F RID: 49311 RVA: 0x001BBD56 File Offset: 0x001B9F56
		public new IVehicleNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new IVehicleNewSplineMoveTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle,
				IsLookDir = this.IsLookDir
			};
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600C0A0 RID: 49312 RVA: 0x001BBD81 File Offset: 0x001B9F81
		// (set) Token: 0x0600C0A1 RID: 49313 RVA: 0x001BBDAC File Offset: 0x001B9FAC
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

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x001BBDBA File Offset: 0x001B9FBA
		// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x001BBDE1 File Offset: 0x001B9FE1
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

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600C0A4 RID: 49316 RVA: 0x001BBDF0 File Offset: 0x001B9FF0
		// (set) Token: 0x0600C0A5 RID: 49317 RVA: 0x001BBE2A File Offset: 0x001BA02A
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

		// Token: 0x04007338 RID: 29496
		[Nullable(2)]
		protected new IVehicleNewSplineMoveTarget FbInstance;

		// Token: 0x04007339 RID: 29497
		[Nullable(2)]
		protected new IVehicleNewSplineMoveTarget_SetValue PocoInterface;
	}
}
