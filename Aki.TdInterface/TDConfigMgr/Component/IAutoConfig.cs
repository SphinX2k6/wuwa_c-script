using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000206 RID: 518
	public class IAutoConfig
	{
		// Token: 0x06000824 RID: 2084 RVA: 0x00026D2C File Offset: 0x00024F2C
		private IAutoConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAutoConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAutoConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAutoConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00026D64 File Offset: 0x00024F64
		public static IAutoConfig Create([Nullable(2)] IAutoConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutoConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00026D77 File Offset: 0x00024F77
		public static IAutoConfig CreateFromSetValue([Nullable(2)] IAutoConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAutoConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00026D8A File Offset: 0x00024F8A
		public IAutoConfig_SetValue ToSetValue()
		{
			return new IAutoConfig_SetValue
			{
				IsCircle = this.IsCircle,
				Interval = this.Interval
			};
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00026DA9 File Offset: 0x00024FA9
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00026DD4 File Offset: 0x00024FD4
		public virtual bool IsCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCircle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsCircle = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00026DE2 File Offset: 0x00024FE2
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00026E0D File Offset: 0x0002500D
		public virtual int Interval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interval;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Interval;
			}
			set
			{
				this.GetOrCreatePoco().Interval = value;
			}
		}

		// Token: 0x04000947 RID: 2375
		[Nullable(2)]
		protected IAutoConfig FbInstance;

		// Token: 0x04000948 RID: 2376
		[Nullable(2)]
		protected IAutoConfig_SetValue PocoInterface;
	}
}
