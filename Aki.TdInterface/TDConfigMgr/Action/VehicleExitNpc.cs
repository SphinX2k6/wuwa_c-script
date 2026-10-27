using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200226F RID: 8815
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleExitNpc : ActionParams
	{
		// Token: 0x0600C166 RID: 49510 RVA: 0x001BBD9C File Offset: 0x001B9F9C
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

		// Token: 0x0600C167 RID: 49511 RVA: 0x001BBDD4 File Offset: 0x001B9FD4
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

		// Token: 0x0600C168 RID: 49512 RVA: 0x001BBDE7 File Offset: 0x001B9FE7
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

		// Token: 0x0600C169 RID: 49513 RVA: 0x001BBDFA File Offset: 0x001B9FFA
		public VehicleExitNpc_SetValue ToSetValue()
		{
			return new VehicleExitNpc_SetValue
			{
				TargetNpc = this.TargetNpc,
				ExitType = this.ExitType
			};
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600C16A RID: 49514 RVA: 0x001BBE19 File Offset: 0x001BA019
		// (set) Token: 0x0600C16B RID: 49515 RVA: 0x001BBE44 File Offset: 0x001BA044
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

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600C16C RID: 49516 RVA: 0x001BBE52 File Offset: 0x001BA052
		// (set) Token: 0x0600C16D RID: 49517 RVA: 0x001BBE79 File Offset: 0x001BA079
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

		// Token: 0x0400733B RID: 29499
		[Nullable(2)]
		protected new VehicleExitNpc FbInstance;

		// Token: 0x0400733C RID: 29500
		[Nullable(2)]
		protected VehicleExitNpc_SetValue PocoInterface;
	}
}
