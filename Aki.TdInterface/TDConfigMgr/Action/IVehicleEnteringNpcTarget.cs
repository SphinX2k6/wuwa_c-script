using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200227E RID: 8830
	public class IVehicleEnteringNpcTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600C05C RID: 49244 RVA: 0x001BB608 File Offset: 0x001B9808
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

		// Token: 0x0600C05D RID: 49245 RVA: 0x001BB640 File Offset: 0x001B9840
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

		// Token: 0x0600C05E RID: 49246 RVA: 0x001BB653 File Offset: 0x001B9853
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

		// Token: 0x0600C05F RID: 49247 RVA: 0x001BB666 File Offset: 0x001B9866
		public new IVehicleEnteringNpcTarget_SetValue ToSetValue()
		{
			return new IVehicleEnteringNpcTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle,
				TargetNpc = this.TargetNpc
			};
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600C060 RID: 49248 RVA: 0x001BB691 File Offset: 0x001B9891
		// (set) Token: 0x0600C061 RID: 49249 RVA: 0x001BB6BC File Offset: 0x001B98BC
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

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600C062 RID: 49250 RVA: 0x001BB6CC File Offset: 0x001B98CC
		// (set) Token: 0x0600C063 RID: 49251 RVA: 0x001BB706 File Offset: 0x001B9906
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

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600C064 RID: 49252 RVA: 0x001BB714 File Offset: 0x001B9914
		// (set) Token: 0x0600C065 RID: 49253 RVA: 0x001BB73F File Offset: 0x001B993F
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

		// Token: 0x0400731C RID: 29468
		[Nullable(2)]
		protected new IVehicleEnteringNpcTarget FbInstance;

		// Token: 0x0400731D RID: 29469
		[Nullable(2)]
		protected new IVehicleEnteringNpcTarget_SetValue PocoInterface;
	}
}
