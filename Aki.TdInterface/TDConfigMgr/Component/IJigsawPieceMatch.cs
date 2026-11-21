using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000501 RID: 1281
	public class IJigsawPieceMatch
	{
		// Token: 0x060019A0 RID: 6560 RVA: 0x0004C04C File Offset: 0x0004A24C
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

		// Token: 0x060019A1 RID: 6561 RVA: 0x0004C084 File Offset: 0x0004A284
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

		// Token: 0x060019A2 RID: 6562 RVA: 0x0004C097 File Offset: 0x0004A297
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

		// Token: 0x060019A3 RID: 6563 RVA: 0x0004C0AA File Offset: 0x0004A2AA
		public IJigsawPieceMatch_SetValue ToSetValue()
		{
			return new IJigsawPieceMatch_SetValue
			{
				EntityId = this.EntityId,
				Index = this.Index
			};
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0004C0C9 File Offset: 0x0004A2C9
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0004C0F4 File Offset: 0x0004A2F4
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

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0004C104 File Offset: 0x0004A304
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0004C165 File Offset: 0x0004A365
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

		// Token: 0x04001302 RID: 4866
		[Nullable(2)]
		protected IJigsawPieceMatch FbInstance;

		// Token: 0x04001303 RID: 4867
		[Nullable(2)]
		protected IJigsawPieceMatch_SetValue PocoInterface;

		// Token: 0x04001304 RID: 4868
		private IPieceIndex _IndexCache;

		// Token: 0x04001305 RID: 4869
		private bool _IndexInited;
	}
}
