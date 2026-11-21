using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024DC RID: 9436
	public class VehicleExitNpc : ActionParams
	{
		// Token: 0x0600CD2C RID: 52524 RVA: 0x001D3520 File Offset: 0x001D1720
		private VehicleExitNpc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleExitNpc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleExitNpc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleExitNpc_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x001D3558 File Offset: 0x001D1758
		public static VehicleExitNpc Create([Nullable(2)] VehicleExitNpc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleExitNpc
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x001D356B File Offset: 0x001D176B
		public static VehicleExitNpc CreateFromSetValue([Nullable(2)] VehicleExitNpc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleExitNpc
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x001D357E File Offset: 0x001D177E
		public VehicleExitNpc_SetValue ToSetValue()
		{
			return new VehicleExitNpc_SetValue
			{
				TargetNpc = this.TargetNpc,
				ExitType = this.ExitType
			};
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600CD30 RID: 52528 RVA: 0x001D359D File Offset: 0x001D179D
		// (set) Token: 0x0600CD31 RID: 52529 RVA: 0x001D35C8 File Offset: 0x001D17C8
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

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600CD32 RID: 52530 RVA: 0x001D35D6 File Offset: 0x001D17D6
		// (set) Token: 0x0600CD33 RID: 52531 RVA: 0x001D35FD File Offset: 0x001D17FD
		public virtual IExitVehicleType ExitType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitType;
				}
				VehicleExitNpc_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitType;
			}
			set
			{
				this.GetOrCreatePoco().ExitType = value;
			}
		}

		// Token: 0x04007988 RID: 31112
		[Nullable(2)]
		protected new VehicleExitNpc FbInstance;

		// Token: 0x04007989 RID: 31113
		[Nullable(2)]
		protected VehicleExitNpc_SetValue PocoInterface;
	}
}
