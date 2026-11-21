using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002290 RID: 8848
	public class IVehicleTeam : ITargetVehicle
	{
		// Token: 0x0600C0BC RID: 49340 RVA: 0x001BC054 File Offset: 0x001BA254
		private IVehicleTeam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleTeam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleTeam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleTeam_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x001BC08C File Offset: 0x001BA28C
		public static IVehicleTeam Create([Nullable(2)] IVehicleTeam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleTeam
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0BE RID: 49342 RVA: 0x001BC09F File Offset: 0x001BA29F
		public static IVehicleTeam CreateFromSetValue([Nullable(2)] IVehicleTeam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleTeam
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x001BC0B2 File Offset: 0x001BA2B2
		public new IVehicleTeam_SetValue ToSetValue()
		{
			return new IVehicleTeam_SetValue
			{
				Type = this.Type,
				TeamId = this.TeamId
			};
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600C0C0 RID: 49344 RVA: 0x001BC0D1 File Offset: 0x001BA2D1
		// (set) Token: 0x0600C0C1 RID: 49345 RVA: 0x001BC0FC File Offset: 0x001BA2FC
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x001BC10A File Offset: 0x001BA30A
		// (set) Token: 0x0600C0C3 RID: 49347 RVA: 0x001BC135 File Offset: 0x001BA335
		public virtual int TeamId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeamId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TeamId;
			}
			set
			{
				this.GetOrCreatePoco().TeamId = value;
			}
		}

		// Token: 0x04007345 RID: 29509
		[Nullable(2)]
		protected new IVehicleTeam FbInstance;

		// Token: 0x04007346 RID: 29510
		[Nullable(2)]
		protected new IVehicleTeam_SetValue PocoInterface;
	}
}
