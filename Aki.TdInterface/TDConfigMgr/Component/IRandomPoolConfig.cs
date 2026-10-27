using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000658 RID: 1624
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomPoolConfig
	{
		// Token: 0x060022BE RID: 8894 RVA: 0x0005F6F0 File Offset: 0x0005D8F0
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

		// Token: 0x060022BF RID: 8895 RVA: 0x0005F728 File Offset: 0x0005D928
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

		// Token: 0x060022C0 RID: 8896 RVA: 0x0005F73B File Offset: 0x0005D93B
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

		// Token: 0x060022C1 RID: 8897 RVA: 0x0005F74E File Offset: 0x0005D94E
		public IRandomPoolConfig_SetValue ToSetValue()
		{
			return new IRandomPoolConfig_SetValue
			{
				Id = this.Id,
				Count = this.Count
			};
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0005F76D File Offset: 0x0005D96D
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x0005F798 File Offset: 0x0005D998
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0005F7A6 File Offset: 0x0005D9A6
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0005F7D1 File Offset: 0x0005D9D1
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

		// Token: 0x04001820 RID: 6176
		[Nullable(2)]
		protected IRandomPoolConfig FbInstance;

		// Token: 0x04001821 RID: 6177
		[Nullable(2)]
		protected IRandomPoolConfig_SetValue PocoInterface;
	}
}
