using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002279 RID: 8825
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleSprint : ActionParams
	{
		// Token: 0x0600C19A RID: 49562 RVA: 0x001BC31C File Offset: 0x001BA51C
		private VehicleSprint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleSprint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleSprint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleSprint_SetValue());
			}
			return result;
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x001BC354 File Offset: 0x001BA554
		public static VehicleSprint Create([Nullable(2)] VehicleSprint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSprint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x001BC367 File Offset: 0x001BA567
		public static VehicleSprint CreateFromSetValue([Nullable(2)] VehicleSprint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleSprint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x001BC37A File Offset: 0x001BA57A
		public VehicleSprint_SetValue ToSetValue()
		{
			return new VehicleSprint_SetValue
			{
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0600C19E RID: 49566 RVA: 0x001BC38D File Offset: 0x001BA58D
		// (set) Token: 0x0600C19F RID: 49567 RVA: 0x001BC3B4 File Offset: 0x001BA5B4
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				VehicleSprint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007352 RID: 29522
		[Nullable(2)]
		protected new VehicleSprint FbInstance;

		// Token: 0x04007353 RID: 29523
		[Nullable(2)]
		protected VehicleSprint_SetValue PocoInterface;
	}
}
