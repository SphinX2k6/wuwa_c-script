using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000634 RID: 1588
	[NullableContext(1)]
	[Nullable(0)]
	public class IPulseDeviceFoundation : IItemFoundationType
	{
		// Token: 0x060021EE RID: 8686 RVA: 0x0005D8A4 File Offset: 0x0005BAA4
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

		// Token: 0x060021EF RID: 8687 RVA: 0x0005D8DC File Offset: 0x0005BADC
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

		// Token: 0x060021F0 RID: 8688 RVA: 0x0005D8EF File Offset: 0x0005BAEF
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

		// Token: 0x060021F1 RID: 8689 RVA: 0x0005D902 File Offset: 0x0005BB02
		public new IPulseDeviceFoundation_SetValue ToSetValue()
		{
			return new IPulseDeviceFoundation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0005D915 File Offset: 0x0005BB15
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x0005D940 File Offset: 0x0005BB40
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

		// Token: 0x0400179E RID: 6046
		[Nullable(2)]
		protected new IPulseDeviceFoundation FbInstance;

		// Token: 0x0400179F RID: 6047
		[Nullable(2)]
		protected new IPulseDeviceFoundation_SetValue PocoInterface;
	}
}
