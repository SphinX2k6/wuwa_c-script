using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A5 RID: 1445
	public class INavMeshAkiEntitySource : INavMeshSourceTypeBase
	{
		// Token: 0x06001D6E RID: 7534 RVA: 0x00054460 File Offset: 0x00052660
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

		// Token: 0x06001D6F RID: 7535 RVA: 0x00054498 File Offset: 0x00052698
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

		// Token: 0x06001D70 RID: 7536 RVA: 0x000544AB File Offset: 0x000526AB
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

		// Token: 0x06001D71 RID: 7537 RVA: 0x000544BE File Offset: 0x000526BE
		public new INavMeshAkiEntitySource_SetValue ToSetValue()
		{
			return new INavMeshAkiEntitySource_SetValue
			{
				Type = this.Type,
				SourceId = this.SourceId
			};
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x000544DD File Offset: 0x000526DD
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x00054508 File Offset: 0x00052708
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

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00054516 File Offset: 0x00052716
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00054541 File Offset: 0x00052741
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

		// Token: 0x04001531 RID: 5425
		[Nullable(2)]
		protected new INavMeshAkiEntitySource FbInstance;

		// Token: 0x04001532 RID: 5426
		[Nullable(2)]
		protected new INavMeshAkiEntitySource_SetValue PocoInterface;
	}
}
