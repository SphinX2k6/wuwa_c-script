using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B31 RID: 6961
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrastructureItemDeliveryRoadBuild : IInfrastructureItemDeliveryType
	{
		// Token: 0x060094FC RID: 38140 RVA: 0x001589E8 File Offset: 0x00156BE8
		private IInfrastructureItemDeliveryRoadBuild_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrastructureItemDeliveryRoadBuild 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrastructureItemDeliveryRoadBuild_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrastructureItemDeliveryRoadBuild_SetValue());
			}
			return result;
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x00158A20 File Offset: 0x00156C20
		public static IInfrastructureItemDeliveryRoadBuild Create([Nullable(2)] IInfrastructureItemDeliveryRoadBuild instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryRoadBuild
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x00158A33 File Offset: 0x00156C33
		public static IInfrastructureItemDeliveryRoadBuild CreateFromSetValue([Nullable(2)] IInfrastructureItemDeliveryRoadBuild_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryRoadBuild
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x00158A46 File Offset: 0x00156C46
		public new IInfrastructureItemDeliveryRoadBuild_SetValue ToSetValue()
		{
			return new IInfrastructureItemDeliveryRoadBuild_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x06009500 RID: 38144 RVA: 0x00158A65 File Offset: 0x00156C65
		// (set) Token: 0x06009501 RID: 38145 RVA: 0x00158A90 File Offset: 0x00156C90
		public override EInfrastructureItemDeliveryType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrastructureItemDeliveryType.Observatory;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x06009502 RID: 38146 RVA: 0x00158A9E File Offset: 0x00156C9E
		// (set) Token: 0x06009503 RID: 38147 RVA: 0x00158AC9 File Offset: 0x00156CC9
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

		// Token: 0x04005B39 RID: 23353
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryRoadBuild FbInstance;

		// Token: 0x04005B3A RID: 23354
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryRoadBuild_SetValue PocoInterface;
	}
}
