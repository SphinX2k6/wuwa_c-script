using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B3 RID: 1203
	public class IInhalationPerformanceType
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x000493EC File Offset: 0x000475EC
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

		// Token: 0x06001820 RID: 6176 RVA: 0x00049424 File Offset: 0x00047624
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

		// Token: 0x06001821 RID: 6177 RVA: 0x00049437 File Offset: 0x00047637
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

		// Token: 0x06001822 RID: 6178 RVA: 0x0004944A File Offset: 0x0004764A
		public IInhalationPerformanceType_SetValue ToSetValue()
		{
			return new IInhalationPerformanceType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x0004945D File Offset: 0x0004765D
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x00049488 File Offset: 0x00047688
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

		// Token: 0x0400124C RID: 4684
		[Nullable(2)]
		protected IInhalationPerformanceType FbInstance;

		// Token: 0x0400124D RID: 4685
		[Nullable(2)]
		protected IInhalationPerformanceType_SetValue PocoInterface;
	}
}
