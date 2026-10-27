using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B33 RID: 6963
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrastructureItemDeliveryType
	{
		// Token: 0x06009506 RID: 38150 RVA: 0x00158AE8 File Offset: 0x00156CE8
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

		// Token: 0x06009507 RID: 38151 RVA: 0x00158B20 File Offset: 0x00156D20
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

		// Token: 0x06009508 RID: 38152 RVA: 0x00158B33 File Offset: 0x00156D33
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

		// Token: 0x06009509 RID: 38153 RVA: 0x00158B46 File Offset: 0x00156D46
		public IInfrastructureItemDeliveryType_SetValue ToSetValue()
		{
			return new IInfrastructureItemDeliveryType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600950A RID: 38154 RVA: 0x00158B59 File Offset: 0x00156D59
		// (set) Token: 0x0600950B RID: 38155 RVA: 0x00158B84 File Offset: 0x00156D84
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

		// Token: 0x04005B3D RID: 23357
		[Nullable(2)]
		protected IInfrastructureItemDeliveryType FbInstance;

		// Token: 0x04005B3E RID: 23358
		[Nullable(2)]
		protected IInfrastructureItemDeliveryType_SetValue PocoInterface;
	}
}
