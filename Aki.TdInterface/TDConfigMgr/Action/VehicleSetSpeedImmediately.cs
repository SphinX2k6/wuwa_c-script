using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002277 RID: 8823
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleSetSpeedImmediately : ActionParams
	{
		// Token: 0x0600C192 RID: 49554 RVA: 0x001BC264 File Offset: 0x001BA464
		private VehicleSetSpeedImmediately_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleSetSpeedImmediately 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleSetSpeedImmediately_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleSetSpeedImmediately_SetValue());
			}
			return result;
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x001BC29C File Offset: 0x001BA49C
		public static VehicleSetSpeedImmediately Create([Nullable(2)] VehicleSetSpeedImmediately instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSetSpeedImmediately
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C194 RID: 49556 RVA: 0x001BC2AF File Offset: 0x001BA4AF
		public static VehicleSetSpeedImmediately CreateFromSetValue([Nullable(2)] VehicleSetSpeedImmediately_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleSetSpeedImmediately
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C195 RID: 49557 RVA: 0x001BC2C2 File Offset: 0x001BA4C2
		public VehicleSetSpeedImmediately_SetValue ToSetValue()
		{
			return new VehicleSetSpeedImmediately_SetValue
			{
				SetSpeedConfig = this.SetSpeedConfig
			};
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600C196 RID: 49558 RVA: 0x001BC2D5 File Offset: 0x001BA4D5
		// (set) Token: 0x0600C197 RID: 49559 RVA: 0x001BC2FC File Offset: 0x001BA4FC
		public virtual ISetVehicleSpeedImmediatelyType SetSpeedConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetSpeedConfig;
				}
				VehicleSetSpeedImmediately_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SetSpeedConfig;
			}
			set
			{
				this.GetOrCreatePoco().SetSpeedConfig = value;
			}
		}

		// Token: 0x0400734F RID: 29519
		[Nullable(2)]
		protected new VehicleSetSpeedImmediately FbInstance;

		// Token: 0x04007350 RID: 29520
		[Nullable(2)]
		protected VehicleSetSpeedImmediately_SetValue PocoInterface;
	}
}
