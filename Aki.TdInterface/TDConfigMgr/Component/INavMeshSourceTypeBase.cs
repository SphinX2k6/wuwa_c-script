using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000540 RID: 1344
	[NullableContext(1)]
	[Nullable(0)]
	public class INavMeshSourceTypeBase
	{
		// Token: 0x06001B7C RID: 7036 RVA: 0x0004F7A4 File Offset: 0x0004D9A4
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

		// Token: 0x06001B7D RID: 7037 RVA: 0x0004F7DC File Offset: 0x0004D9DC
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

		// Token: 0x06001B7E RID: 7038 RVA: 0x0004F7EF File Offset: 0x0004D9EF
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

		// Token: 0x06001B7F RID: 7039 RVA: 0x0004F802 File Offset: 0x0004DA02
		public INavMeshSourceTypeBase_SetValue ToSetValue()
		{
			return new INavMeshSourceTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x0004F815 File Offset: 0x0004DA15
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0004F840 File Offset: 0x0004DA40
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

		// Token: 0x040013CB RID: 5067
		[Nullable(2)]
		protected INavMeshSourceTypeBase FbInstance;

		// Token: 0x040013CC RID: 5068
		[Nullable(2)]
		protected INavMeshSourceTypeBase_SetValue PocoInterface;
	}
}
