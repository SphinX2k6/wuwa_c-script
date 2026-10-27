using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2F RID: 6959
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrastructureItemDeliveryObservatory : IInfrastructureItemDeliveryType
	{
		// Token: 0x060094F2 RID: 38130 RVA: 0x001588E8 File Offset: 0x00156AE8
		private IInfrastructureItemDeliveryObservatory_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrastructureItemDeliveryObservatory 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrastructureItemDeliveryObservatory_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrastructureItemDeliveryObservatory_SetValue());
			}
			return result;
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00158920 File Offset: 0x00156B20
		public static IInfrastructureItemDeliveryObservatory Create([Nullable(2)] IInfrastructureItemDeliveryObservatory instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryObservatory
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x00158933 File Offset: 0x00156B33
		public static IInfrastructureItemDeliveryObservatory CreateFromSetValue([Nullable(2)] IInfrastructureItemDeliveryObservatory_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryObservatory
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x00158946 File Offset: 0x00156B46
		public new IInfrastructureItemDeliveryObservatory_SetValue ToSetValue()
		{
			return new IInfrastructureItemDeliveryObservatory_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x060094F6 RID: 38134 RVA: 0x00158965 File Offset: 0x00156B65
		// (set) Token: 0x060094F7 RID: 38135 RVA: 0x00158990 File Offset: 0x00156B90
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

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x060094F8 RID: 38136 RVA: 0x0015899E File Offset: 0x00156B9E
		// (set) Token: 0x060094F9 RID: 38137 RVA: 0x001589C9 File Offset: 0x00156BC9
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

		// Token: 0x04005B35 RID: 23349
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryObservatory FbInstance;

		// Token: 0x04005B36 RID: 23350
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryObservatory_SetValue PocoInterface;
	}
}
