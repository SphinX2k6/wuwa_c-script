using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B5 RID: 1973
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleGenerateByVehicleEntityTemplate : IVehicleGenerationType
	{
		// Token: 0x06002AC1 RID: 10945 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
		private IVehicleGenerateByVehicleEntityTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleGenerateByVehicleEntityTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleGenerateByVehicleEntityTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleGenerateByVehicleEntityTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0006FF2C File Offset: 0x0006E12C
		public static IVehicleGenerateByVehicleEntityTemplate Create([Nullable(2)] IVehicleGenerateByVehicleEntityTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleEntityTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x0006FF3F File Offset: 0x0006E13F
		public static IVehicleGenerateByVehicleEntityTemplate CreateFromSetValue([Nullable(2)] IVehicleGenerateByVehicleEntityTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleEntityTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x0006FF52 File Offset: 0x0006E152
		public new IVehicleGenerateByVehicleEntityTemplate_SetValue ToSetValue()
		{
			return new IVehicleGenerateByVehicleEntityTemplate_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				Weight = this.Weight
			};
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0006FF7D File Offset: 0x0006E17D
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0006FFA8 File Offset: 0x0006E1A8
		public override EVehicleGenerationType Type
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

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0006FFB6 File Offset: 0x0006E1B6
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0006FFE1 File Offset: 0x0006E1E1
		public override int Id
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

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0006FFEF File Offset: 0x0006E1EF
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0007001A File Offset: 0x0006E21A
		public override int Weight
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

		// Token: 0x04001C7C RID: 7292
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleEntityTemplate FbInstance;

		// Token: 0x04001C7D RID: 7293
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleEntityTemplate_SetValue PocoInterface;
	}
}
