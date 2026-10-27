using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200045A RID: 1114
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhalationPerformanceType
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x000456A4 File Offset: 0x000438A4
		private IInhalationPerformanceType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhalationPerformanceType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhalationPerformanceType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhalationPerformanceType_SetValue());
			}
			return result;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000456DC File Offset: 0x000438DC
		public static IInhalationPerformanceType Create([Nullable(2)] IInhalationPerformanceType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationPerformanceType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000456EF File Offset: 0x000438EF
		public static IInhalationPerformanceType CreateFromSetValue([Nullable(2)] IInhalationPerformanceType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhalationPerformanceType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00045702 File Offset: 0x00043902
		public IInhalationPerformanceType_SetValue ToSetValue()
		{
			return new IInhalationPerformanceType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00045715 File Offset: 0x00043915
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00045740 File Offset: 0x00043940
		public virtual EInhalationPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhalationPerformanceType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400112A RID: 4394
		[Nullable(2)]
		protected IInhalationPerformanceType FbInstance;

		// Token: 0x0400112B RID: 4395
		[Nullable(2)]
		protected IInhalationPerformanceType_SetValue PocoInterface;
	}
}
