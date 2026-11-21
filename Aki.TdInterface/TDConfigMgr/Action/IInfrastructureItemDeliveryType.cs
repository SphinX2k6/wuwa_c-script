using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE2 RID: 7394
	public class IInfrastructureItemDeliveryType
	{
		// Token: 0x06009CF0 RID: 40176 RVA: 0x001697C4 File Offset: 0x001679C4
		private IInfrastructureItemDeliveryType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrastructureItemDeliveryType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrastructureItemDeliveryType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrastructureItemDeliveryType_SetValue());
			}
			return result;
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x001697FC File Offset: 0x001679FC
		public static IInfrastructureItemDeliveryType Create([Nullable(2)] IInfrastructureItemDeliveryType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x0016980F File Offset: 0x00167A0F
		public static IInfrastructureItemDeliveryType CreateFromSetValue([Nullable(2)] IInfrastructureItemDeliveryType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x00169822 File Offset: 0x00167A22
		public IInfrastructureItemDeliveryType_SetValue ToSetValue()
		{
			return new IInfrastructureItemDeliveryType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x00169835 File Offset: 0x00167A35
		// (set) Token: 0x06009CF5 RID: 40181 RVA: 0x00169860 File Offset: 0x00167A60
		public virtual EInfrastructureItemDeliveryType Type
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

		// Token: 0x04005FDB RID: 24539
		[Nullable(2)]
		protected IInfrastructureItemDeliveryType FbInstance;

		// Token: 0x04005FDC RID: 24540
		[Nullable(2)]
		protected IInfrastructureItemDeliveryType_SetValue PocoInterface;
	}
}
