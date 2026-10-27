using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B7 RID: 1975
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleGenerateByVehicleTeamTemplate : IVehicleGenerationType
	{
		// Token: 0x06002ACD RID: 10957 RVA: 0x00070038 File Offset: 0x0006E238
		private IVehicleGenerateByVehicleTeamTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleGenerateByVehicleTeamTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleGenerateByVehicleTeamTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleGenerateByVehicleTeamTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00070070 File Offset: 0x0006E270
		public static IVehicleGenerateByVehicleTeamTemplate Create([Nullable(2)] IVehicleGenerateByVehicleTeamTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleTeamTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00070083 File Offset: 0x0006E283
		public static IVehicleGenerateByVehicleTeamTemplate CreateFromSetValue([Nullable(2)] IVehicleGenerateByVehicleTeamTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleTeamTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00070096 File Offset: 0x0006E296
		public new IVehicleGenerateByVehicleTeamTemplate_SetValue ToSetValue()
		{
			return new IVehicleGenerateByVehicleTeamTemplate_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				Weight = this.Weight
			};
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x000700C1 File Offset: 0x0006E2C1
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x000700EC File Offset: 0x0006E2EC
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

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000700FA File Offset: 0x0006E2FA
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x00070125 File Offset: 0x0006E325
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x00070133 File Offset: 0x0006E333
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x0007015E File Offset: 0x0006E35E
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

		// Token: 0x04001C81 RID: 7297
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleTeamTemplate FbInstance;

		// Token: 0x04001C82 RID: 7298
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleTeamTemplate_SetValue PocoInterface;
	}
}
