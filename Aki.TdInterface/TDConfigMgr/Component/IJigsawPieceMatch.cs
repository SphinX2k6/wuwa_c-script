using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A8 RID: 1192
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawPieceMatch
	{
		// Token: 0x06001806 RID: 6150 RVA: 0x00048304 File Offset: 0x00046504
		private IJigsawPieceMatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawPieceMatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawPieceMatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawPieceMatch_SetValue());
			}
			return result;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0004833C File Offset: 0x0004653C
		public static IJigsawPieceMatch Create([Nullable(2)] IJigsawPieceMatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawPieceMatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0004834F File Offset: 0x0004654F
		public static IJigsawPieceMatch CreateFromSetValue([Nullable(2)] IJigsawPieceMatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawPieceMatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00048362 File Offset: 0x00046562
		public IJigsawPieceMatch_SetValue ToSetValue()
		{
			return new IJigsawPieceMatch_SetValue
			{
				EntityId = this.EntityId,
				Index = this.Index
			};
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x00048381 File Offset: 0x00046581
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x000483AC File Offset: 0x000465AC
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000483BC File Offset: 0x000465BC
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0004841D File Offset: 0x0004661D
		public virtual IPieceIndex Index
		{
			get
			{
				if (this._IndexInited)
				{
					return this._IndexCache;
				}
				this._IndexInited = true;
				if (this.FbInstance != null)
				{
					this._IndexCache = IPieceIndex.Create(this.FbInstance.Index);
				}
				else
				{
					IJigsawPieceMatch_SetValue pocoInterface = this.PocoInterface;
					this._IndexCache = ((pocoInterface != null) ? pocoInterface.Index : null);
				}
				return this._IndexCache;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
				this._IndexInited = false;
			}
		}

		// Token: 0x040011E0 RID: 4576
		[Nullable(2)]
		protected IJigsawPieceMatch FbInstance;

		// Token: 0x040011E1 RID: 4577
		[Nullable(2)]
		protected IJigsawPieceMatch_SetValue PocoInterface;

		// Token: 0x040011E2 RID: 4578
		private IPieceIndex _IndexCache;

		// Token: 0x040011E3 RID: 4579
		private bool _IndexInited;
	}
}
