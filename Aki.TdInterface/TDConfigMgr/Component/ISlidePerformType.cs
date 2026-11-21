using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200077B RID: 1915
	public class ISlidePerformType
	{
		// Token: 0x060028EC RID: 10476 RVA: 0x0006CAC0 File Offset: 0x0006ACC0
		private ISlidePerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlidePerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlidePerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlidePerformType_SetValue());
			}
			return result;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0006CAF8 File Offset: 0x0006ACF8
		public static ISlidePerformType Create([Nullable(2)] ISlidePerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlidePerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0006CB0B File Offset: 0x0006AD0B
		public static ISlidePerformType CreateFromSetValue([Nullable(2)] ISlidePerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlidePerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0006CB1E File Offset: 0x0006AD1E
		public ISlidePerformType_SetValue ToSetValue()
		{
			return new ISlidePerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x0006CB31 File Offset: 0x0006AD31
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x0006CB5C File Offset: 0x0006AD5C
		public virtual ESlidePerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BC3 RID: 7107
		[Nullable(2)]
		protected ISlidePerformType FbInstance;

		// Token: 0x04001BC4 RID: 7108
		[Nullable(2)]
		protected ISlidePerformType_SetValue PocoInterface;
	}
}
