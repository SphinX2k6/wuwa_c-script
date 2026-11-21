using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002280 RID: 8832
	public class IVehicleEnteringPlayerTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600C068 RID: 49256 RVA: 0x001BB760 File Offset: 0x001B9960
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

		// Token: 0x0600C069 RID: 49257 RVA: 0x001BB798 File Offset: 0x001B9998
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

		// Token: 0x0600C06A RID: 49258 RVA: 0x001BB7AB File Offset: 0x001B99AB
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

		// Token: 0x0600C06B RID: 49259 RVA: 0x001BB7BE File Offset: 0x001B99BE
		public new IVehicleEnteringPlayerTarget_SetValue ToSetValue()
		{
			return new IVehicleEnteringPlayerTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600C06C RID: 49260 RVA: 0x001BB7DD File Offset: 0x001B99DD
		// (set) Token: 0x0600C06D RID: 49261 RVA: 0x001BB808 File Offset: 0x001B9A08
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

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0600C06E RID: 49262 RVA: 0x001BB818 File Offset: 0x001B9A18
		// (set) Token: 0x0600C06F RID: 49263 RVA: 0x001BB852 File Offset: 0x001B9A52
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

		// Token: 0x04007321 RID: 29473
		[Nullable(2)]
		protected new IVehicleEnteringPlayerTarget FbInstance;

		// Token: 0x04007322 RID: 29474
		[Nullable(2)]
		protected new IVehicleEnteringPlayerTarget_SetValue PocoInterface;
	}
}
