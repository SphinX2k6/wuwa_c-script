using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F5 RID: 1781
	public class IRandomPoolConfig
	{
		// Token: 0x060025C4 RID: 9668 RVA: 0x00066404 File Offset: 0x00064604
		private IRandomPoolConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomPoolConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomPoolConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomPoolConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0006643C File Offset: 0x0006463C
		public static IRandomPoolConfig Create([Nullable(2)] IRandomPoolConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPoolConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0006644F File Offset: 0x0006464F
		public static IRandomPoolConfig CreateFromSetValue([Nullable(2)] IRandomPoolConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomPoolConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00066462 File Offset: 0x00064662
		public IRandomPoolConfig_SetValue ToSetValue()
		{
			return new IRandomPoolConfig_SetValue
			{
				Id = this.Id,
				Count = this.Count
			};
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x00066481 File Offset: 0x00064681
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x000664AC File Offset: 0x000646AC
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000664BA File Offset: 0x000646BA
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x000664E5 File Offset: 0x000646E5
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x04001A12 RID: 6674
		[Nullable(2)]
		protected IRandomPoolConfig FbInstance;

		// Token: 0x04001A13 RID: 6675
		[Nullable(2)]
		protected IRandomPoolConfig_SetValue PocoInterface;
	}
}
