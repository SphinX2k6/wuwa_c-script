using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085A RID: 2138
	public class IVehicleGenerateByVehicleTeamTemplate : IVehicleGenerationType
	{
		// Token: 0x06002DFD RID: 11773 RVA: 0x0007739C File Offset: 0x0007559C
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

		// Token: 0x06002DFE RID: 11774 RVA: 0x000773D4 File Offset: 0x000755D4
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

		// Token: 0x06002DFF RID: 11775 RVA: 0x000773E7 File Offset: 0x000755E7
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

		// Token: 0x06002E00 RID: 11776 RVA: 0x000773FA File Offset: 0x000755FA
		public new IVehicleGenerateByVehicleTeamTemplate_SetValue ToSetValue()
		{
			return new IVehicleGenerateByVehicleTeamTemplate_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				Weight = this.Weight
			};
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00077425 File Offset: 0x00075625
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00077450 File Offset: 0x00075650
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

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x0007745E File Offset: 0x0007565E
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00077489 File Offset: 0x00075689
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

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x00077497 File Offset: 0x00075697
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x000774C2 File Offset: 0x000756C2
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

		// Token: 0x04001E8D RID: 7821
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleTeamTemplate FbInstance;

		// Token: 0x04001E8E RID: 7822
		[Nullable(2)]
		protected new IVehicleGenerateByVehicleTeamTemplate_SetValue PocoInterface;
	}
}
