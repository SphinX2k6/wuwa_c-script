using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024DE RID: 9438
	public class VehicleExitPlayer : ActionParams
	{
		// Token: 0x0600CD36 RID: 52534 RVA: 0x001D361C File Offset: 0x001D181C
		private VehicleExitPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleExitPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleExitPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleExitPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x001D3654 File Offset: 0x001D1854
		public static VehicleExitPlayer Create([Nullable(2)] VehicleExitPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleExitPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD38 RID: 52536 RVA: 0x001D3667 File Offset: 0x001D1867
		public static VehicleExitPlayer CreateFromSetValue([Nullable(2)] VehicleExitPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleExitPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD39 RID: 52537 RVA: 0x001D367A File Offset: 0x001D187A
		public VehicleExitPlayer_SetValue ToSetValue()
		{
			return new VehicleExitPlayer_SetValue
			{
				DestroyVehicle = this.DestroyVehicle,
				ExitType = this.ExitType
			};
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x001D369C File Offset: 0x001D189C
		// (set) Token: 0x0600CD3B RID: 52539 RVA: 0x001D36D6 File Offset: 0x001D18D6
		public virtual bool? DestroyVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyVehicle;
				}
				VehicleExitPlayer_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DestroyVehicle;
			}
			set
			{
				this.GetOrCreatePoco().DestroyVehicle = value;
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x001D36E4 File Offset: 0x001D18E4
		// (set) Token: 0x0600CD3D RID: 52541 RVA: 0x001D370B File Offset: 0x001D190B
		public virtual IExitVehicleType ExitType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitType;
				}
				VehicleExitPlayer_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400798C RID: 31116
		[Nullable(2)]
		protected new VehicleExitPlayer FbInstance;

		// Token: 0x0400798D RID: 31117
		[Nullable(2)]
		protected VehicleExitPlayer_SetValue PocoInterface;
	}
}
