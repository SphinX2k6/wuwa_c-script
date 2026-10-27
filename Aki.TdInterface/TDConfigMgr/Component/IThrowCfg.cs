using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000764 RID: 1892
	[NullableContext(1)]
	[Nullable(0)]
	public class IThrowCfg
	{
		// Token: 0x060028E5 RID: 10469 RVA: 0x0006C2C4 File Offset: 0x0006A4C4
		private IThrowCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IThrowCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IThrowCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IThrowCfg_SetValue());
			}
			return result;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0006C2FC File Offset: 0x0006A4FC
		public static IThrowCfg Create([Nullable(2)] IThrowCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0006C30F File Offset: 0x0006A50F
		public static IThrowCfg CreateFromSetValue([Nullable(2)] IThrowCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IThrowCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0006C322 File Offset: 0x0006A522
		public IThrowCfg_SetValue ToSetValue()
		{
			return new IThrowCfg_SetValue
			{
				MotionConfig = this.MotionConfig
			};
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0006C335 File Offset: 0x0006A535
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x0006C35C File Offset: 0x0006A55C
		public virtual IThrowMotion MotionConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotionConfig;
				}
				IThrowCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MotionConfig;
			}
			set
			{
				this.GetOrCreatePoco().MotionConfig = value;
			}
		}

		// Token: 0x04001B7E RID: 7038
		[Nullable(2)]
		protected IThrowCfg FbInstance;

		// Token: 0x04001B7F RID: 7039
		[Nullable(2)]
		protected IThrowCfg_SetValue PocoInterface;
	}
}
