using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CDE RID: 7390
	public class IInfrastructureItemDeliveryObservatory : IInfrastructureItemDeliveryType
	{
		// Token: 0x06009CDC RID: 40156 RVA: 0x001695C4 File Offset: 0x001677C4
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

		// Token: 0x06009CDD RID: 40157 RVA: 0x001695FC File Offset: 0x001677FC
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

		// Token: 0x06009CDE RID: 40158 RVA: 0x0016960F File Offset: 0x0016780F
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

		// Token: 0x06009CDF RID: 40159 RVA: 0x00169622 File Offset: 0x00167822
		public new IInfrastructureItemDeliveryObservatory_SetValue ToSetValue()
		{
			return new IInfrastructureItemDeliveryObservatory_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06009CE0 RID: 40160 RVA: 0x00169641 File Offset: 0x00167841
		// (set) Token: 0x06009CE1 RID: 40161 RVA: 0x0016966C File Offset: 0x0016786C
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

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06009CE2 RID: 40162 RVA: 0x0016967A File Offset: 0x0016787A
		// (set) Token: 0x06009CE3 RID: 40163 RVA: 0x001696A5 File Offset: 0x001678A5
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

		// Token: 0x04005FD3 RID: 24531
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryObservatory FbInstance;

		// Token: 0x04005FD4 RID: 24532
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryObservatory_SetValue PocoInterface;
	}
}
