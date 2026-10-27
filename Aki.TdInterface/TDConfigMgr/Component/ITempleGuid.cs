using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000762 RID: 1890
	[NullableContext(1)]
	[Nullable(0)]
	public class ITempleGuid
	{
		// Token: 0x060028DD RID: 10461 RVA: 0x0006C208 File Offset: 0x0006A408
		private ITempleGuid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITempleGuid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITempleGuid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITempleGuid_SetValue());
			}
			return result;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0006C240 File Offset: 0x0006A440
		public static ITempleGuid Create([Nullable(2)] ITempleGuid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITempleGuid
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0006C253 File Offset: 0x0006A453
		public static ITempleGuid CreateFromSetValue([Nullable(2)] ITempleGuid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITempleGuid
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0006C266 File Offset: 0x0006A466
		public ITempleGuid_SetValue ToSetValue()
		{
			return new ITempleGuid_SetValue
			{
				TempleGuid = this.TempleGuid
			};
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0006C279 File Offset: 0x0006A479
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
		public virtual int TempleGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TempleGuid;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TempleGuid;
			}
			set
			{
				this.GetOrCreatePoco().TempleGuid = value;
			}
		}

		// Token: 0x04001B7B RID: 7035
		[Nullable(2)]
		protected ITempleGuid FbInstance;

		// Token: 0x04001B7C RID: 7036
		[Nullable(2)]
		protected ITempleGuid_SetValue PocoInterface;
	}
}
