using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A7 RID: 1447
	public class INavMeshSourceTypeBase
	{
		// Token: 0x06001D78 RID: 7544 RVA: 0x00054560 File Offset: 0x00052760
		private INavMeshSourceTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INavMeshSourceTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INavMeshSourceTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INavMeshSourceTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00054598 File Offset: 0x00052798
		public static INavMeshSourceTypeBase Create([Nullable(2)] INavMeshSourceTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INavMeshSourceTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000545AB File Offset: 0x000527AB
		public static INavMeshSourceTypeBase CreateFromSetValue([Nullable(2)] INavMeshSourceTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INavMeshSourceTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000545BE File Offset: 0x000527BE
		public INavMeshSourceTypeBase_SetValue ToSetValue()
		{
			return new INavMeshSourceTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000545D1 File Offset: 0x000527D1
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x000545FC File Offset: 0x000527FC
		public virtual ENavMeshSourceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENavMeshSourceType.AkiEntitySource;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001535 RID: 5429
		[Nullable(2)]
		protected INavMeshSourceTypeBase FbInstance;

		// Token: 0x04001536 RID: 5430
		[Nullable(2)]
		protected INavMeshSourceTypeBase_SetValue PocoInterface;
	}
}
