using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E30 RID: 7728
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcGroupPerformType
	{
		// Token: 0x0600A54F RID: 42319 RVA: 0x00176840 File Offset: 0x00174A40
		private ISetNpcGroupPerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcGroupPerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcGroupPerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcGroupPerformType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A550 RID: 42320 RVA: 0x00176878 File Offset: 0x00174A78
		public static ISetNpcGroupPerformType Create([Nullable(2)] ISetNpcGroupPerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcGroupPerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x0017688B File Offset: 0x00174A8B
		public static ISetNpcGroupPerformType CreateFromSetValue([Nullable(2)] ISetNpcGroupPerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcGroupPerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x0017689E File Offset: 0x00174A9E
		public ISetNpcGroupPerformType_SetValue ToSetValue()
		{
			return new ISetNpcGroupPerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600A553 RID: 42323 RVA: 0x001768B1 File Offset: 0x00174AB1
		// (set) Token: 0x0600A554 RID: 42324 RVA: 0x001768DC File Offset: 0x00174ADC
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040062DB RID: 25307
		[Nullable(2)]
		protected ISetNpcGroupPerformType FbInstance;

		// Token: 0x040062DC RID: 25308
		[Nullable(2)]
		protected ISetNpcGroupPerformType_SetValue PocoInterface;
	}
}
