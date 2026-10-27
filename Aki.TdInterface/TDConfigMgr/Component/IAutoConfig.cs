using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DF RID: 479
	[NullableContext(1)]
	[Nullable(0)]
	public class IAutoConfig
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x0002564C File Offset: 0x0002384C
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

		// Token: 0x060007B7 RID: 1975 RVA: 0x00025684 File Offset: 0x00023884
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

		// Token: 0x060007B8 RID: 1976 RVA: 0x00025697 File Offset: 0x00023897
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x000256AA File Offset: 0x000238AA
		public IAutoConfig_SetValue ToSetValue()
		{
			return new IAutoConfig_SetValue
			{
				IsCircle = this.IsCircle,
				Interval = this.Interval
			};
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000256C9 File Offset: 0x000238C9
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x000256F4 File Offset: 0x000238F4
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00025702 File Offset: 0x00023902
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0002572D File Offset: 0x0002392D
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

		// Token: 0x040008C0 RID: 2240
		[Nullable(2)]
		protected IAutoConfig FbInstance;

		// Token: 0x040008C1 RID: 2241
		[Nullable(2)]
		protected IAutoConfig_SetValue PocoInterface;
	}
}
