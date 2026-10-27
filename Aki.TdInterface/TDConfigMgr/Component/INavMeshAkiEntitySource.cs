using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053E RID: 1342
	[NullableContext(1)]
	[Nullable(0)]
	public class INavMeshAkiEntitySource : INavMeshSourceTypeBase
	{
		// Token: 0x06001B72 RID: 7026 RVA: 0x0004F6A4 File Offset: 0x0004D8A4
		private INavMeshAkiEntitySource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INavMeshAkiEntitySource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INavMeshAkiEntitySource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INavMeshAkiEntitySource_SetValue());
			}
			return result;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0004F6DC File Offset: 0x0004D8DC
		public static INavMeshAkiEntitySource Create([Nullable(2)] INavMeshAkiEntitySource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INavMeshAkiEntitySource
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0004F6EF File Offset: 0x0004D8EF
		public static INavMeshAkiEntitySource CreateFromSetValue([Nullable(2)] INavMeshAkiEntitySource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INavMeshAkiEntitySource
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0004F702 File Offset: 0x0004D902
		public new INavMeshAkiEntitySource_SetValue ToSetValue()
		{
			return new INavMeshAkiEntitySource_SetValue
			{
				Type = this.Type,
				SourceId = this.SourceId
			};
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0004F721 File Offset: 0x0004D921
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0004F74C File Offset: 0x0004D94C
		public override ENavMeshSourceType Type
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0004F75A File Offset: 0x0004D95A
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0004F785 File Offset: 0x0004D985
		public virtual int SourceId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SourceId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SourceId;
			}
			set
			{
				this.GetOrCreatePoco().SourceId = value;
			}
		}

		// Token: 0x040013C7 RID: 5063
		[Nullable(2)]
		protected new INavMeshAkiEntitySource FbInstance;

		// Token: 0x040013C8 RID: 5064
		[Nullable(2)]
		protected new INavMeshAkiEntitySource_SetValue PocoInterface;
	}
}
