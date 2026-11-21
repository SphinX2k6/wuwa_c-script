using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085E RID: 2142
	public class IVehicleGenerationType
	{
		// Token: 0x06002E19 RID: 11801 RVA: 0x00077770 File Offset: 0x00075970
		private IVehicleGenerationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleGenerationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleGenerationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleGenerationType_SetValue());
			}
			return result;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x000777A8 File Offset: 0x000759A8
		public static IVehicleGenerationType Create([Nullable(2)] IVehicleGenerationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000777BB File Offset: 0x000759BB
		public static IVehicleGenerationType CreateFromSetValue([Nullable(2)] IVehicleGenerationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleGenerationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000777CE File Offset: 0x000759CE
		public IVehicleGenerationType_SetValue ToSetValue()
		{
			return new IVehicleGenerationType_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				Weight = this.Weight
			};
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x000777F9 File Offset: 0x000759F9
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00077824 File Offset: 0x00075A24
		public virtual EVehicleGenerationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleGenerationType.VehicleEntityTemplate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x00077832 File Offset: 0x00075A32
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0007785D File Offset: 0x00075A5D
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x0007786B File Offset: 0x00075A6B
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x00077896 File Offset: 0x00075A96
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x04001E9D RID: 7837
		[Nullable(2)]
		protected IVehicleGenerationType FbInstance;

		// Token: 0x04001E9E RID: 7838
		[Nullable(2)]
		protected IVehicleGenerationType_SetValue PocoInterface;
	}
}
