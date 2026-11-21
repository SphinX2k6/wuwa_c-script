using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D1 RID: 1745
	public class IPulseDeviceFoundation : IItemFoundationType
	{
		// Token: 0x060024F4 RID: 9460 RVA: 0x000645B8 File Offset: 0x000627B8
		private IPulseDeviceFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPulseDeviceFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPulseDeviceFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPulseDeviceFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000645F0 File Offset: 0x000627F0
		public static IPulseDeviceFoundation Create([Nullable(2)] IPulseDeviceFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPulseDeviceFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00064603 File Offset: 0x00062803
		public static IPulseDeviceFoundation CreateFromSetValue([Nullable(2)] IPulseDeviceFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPulseDeviceFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00064616 File Offset: 0x00062816
		public new IPulseDeviceFoundation_SetValue ToSetValue()
		{
			return new IPulseDeviceFoundation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00064629 File Offset: 0x00062829
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00064654 File Offset: 0x00062854
		public override EItemFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EItemFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001990 RID: 6544
		[Nullable(2)]
		protected new IPulseDeviceFoundation FbInstance;

		// Token: 0x04001991 RID: 6545
		[Nullable(2)]
		protected new IPulseDeviceFoundation_SetValue PocoInterface;
	}
}
