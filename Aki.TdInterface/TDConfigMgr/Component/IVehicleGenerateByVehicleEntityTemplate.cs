using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000858 RID: 2136
	public class IVehicleGenerateByVehicleEntityTemplate : IVehicleGenerationType
	{
		// Token: 0x06002DF1 RID: 11761 RVA: 0x00077258 File Offset: 0x00075458
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

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00077290 File Offset: 0x00075490
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

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000772A3 File Offset: 0x000754A3
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

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000772B6 File Offset: 0x000754B6
		public new IVehicleGenerateByVehicleEntityTemplate_SetValue ToSetValue()
		{
			return new IVehicleGenerateByVehicleEntityTemplate_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				Weight = this.Weight
			};
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000772E1 File Offset: 0x000754E1
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x0007730C File Offset: 0x0007550C
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x0007731A File Offset: 0x0007551A
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x00077345 File Offset: 0x00075545
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

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x00077353 File Offset: 0x00075553
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x0007737E File Offset: 0x0007557E
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

		// Token: 0x04001E88 RID: 7816
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleEntityTemplate FbInstance;

		// Token: 0x04001E89 RID: 7817
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleEntityTemplate_SetValue PocoInterface;
	}
}
