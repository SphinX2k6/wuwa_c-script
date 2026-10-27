using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BB RID: 1979
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleGenerationType
	{
		// Token: 0x06002AE9 RID: 10985 RVA: 0x0007040C File Offset: 0x0006E60C
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

		// Token: 0x06002AEA RID: 10986 RVA: 0x00070444 File Offset: 0x0006E644
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

		// Token: 0x06002AEB RID: 10987 RVA: 0x00070457 File Offset: 0x0006E657
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

		// Token: 0x06002AEC RID: 10988 RVA: 0x0007046A File Offset: 0x0006E66A
		public IVehicleGenerationType_SetValue ToSetValue()
		{
			return new IVehicleGenerationType_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				Weight = this.Weight
			};
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x00070495 File Offset: 0x0006E695
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x000704C0 File Offset: 0x0006E6C0
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

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000704CE File Offset: 0x0006E6CE
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x000704F9 File Offset: 0x0006E6F9
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

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x00070507 File Offset: 0x0006E707
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x00070532 File Offset: 0x0006E732
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

		// Token: 0x04001C91 RID: 7313
		[Nullable(2)]
		protected IVehicleGenerationType FbInstance;

		// Token: 0x04001C92 RID: 7314
		[Nullable(2)]
		protected IVehicleGenerationType_SetValue PocoInterface;
	}
}
