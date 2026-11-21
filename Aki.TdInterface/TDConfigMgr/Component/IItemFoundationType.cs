using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F7 RID: 1271
	public class IItemFoundationType
	{
		// Token: 0x0600196C RID: 6508 RVA: 0x0004B940 File Offset: 0x00049B40
		private IItemFoundationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemFoundationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemFoundationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemFoundationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0004B978 File Offset: 0x00049B78
		public static IItemFoundationType Create([Nullable(2)] IItemFoundationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemFoundationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0004B98B File Offset: 0x00049B8B
		public static IItemFoundationType CreateFromSetValue([Nullable(2)] IItemFoundationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemFoundationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0004B99E File Offset: 0x00049B9E
		public IItemFoundationType_SetValue ToSetValue()
		{
			return new IItemFoundationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x0004B9B1 File Offset: 0x00049BB1
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0004B9DC File Offset: 0x00049BDC
		public virtual EItemFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EItemFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012E5 RID: 4837
		[Nullable(2)]
		protected IItemFoundationType FbInstance;

		// Token: 0x040012E6 RID: 4838
		[Nullable(2)]
		protected IItemFoundationType_SetValue PocoInterface;
	}
}
