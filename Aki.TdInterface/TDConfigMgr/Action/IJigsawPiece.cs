using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D17 RID: 7447
	public class IJigsawPiece : IPieceBase
	{
		// Token: 0x06009E2F RID: 40495 RVA: 0x0016BFD4 File Offset: 0x0016A1D4
		private IJigsawPiece_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawPiece 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawPiece_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawPiece_SetValue());
			}
			return result;
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x0016C00C File Offset: 0x0016A20C
		public static IJigsawPiece Create([Nullable(2)] IJigsawPiece instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawPiece
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x0016C01F File Offset: 0x0016A21F
		public static IJigsawPiece CreateFromSetValue([Nullable(2)] IJigsawPiece_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawPiece
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E32 RID: 40498 RVA: 0x0016C032 File Offset: 0x0016A232
		public new IJigsawPiece_SetValue ToSetValue()
		{
			return new IJigsawPiece_SetValue
			{
				Index = this.Index,
				Active = this.Active,
				IsCorrect = this.IsCorrect,
				InitState = this.InitState
			};
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x06009E33 RID: 40499 RVA: 0x0016C06C File Offset: 0x0016A26C
		// (set) Token: 0x06009E34 RID: 40500 RVA: 0x0016C0CD File Offset: 0x0016A2CD
		public override IPieceIndex Index
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
					IJigsawPiece_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x06009E35 RID: 40501 RVA: 0x0016C0E2 File Offset: 0x0016A2E2
		// (set) Token: 0x06009E36 RID: 40502 RVA: 0x0016C10D File Offset: 0x0016A30D
		public override bool Active
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Active;
				}
				return this.PocoInterface != null && this.PocoInterface.Active;
			}
			set
			{
				this.GetOrCreatePoco().Active = value;
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x06009E37 RID: 40503 RVA: 0x0016C11B File Offset: 0x0016A31B
		// (set) Token: 0x06009E38 RID: 40504 RVA: 0x0016C146 File Offset: 0x0016A346
		public virtual bool IsCorrect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCorrect;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCorrect;
			}
			set
			{
				this.GetOrCreatePoco().IsCorrect = value;
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x0016C154 File Offset: 0x0016A354
		// (set) Token: 0x06009E3A RID: 40506 RVA: 0x0016C17F File Offset: 0x0016A37F
		public virtual EJigsawPieceState InitState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitState;
				}
				if (this.PocoInterface == null)
				{
					return EJigsawPieceState.Disable;
				}
				return this.PocoInterface.InitState;
			}
			set
			{
				this.GetOrCreatePoco().InitState = value;
			}
		}

		// Token: 0x04006084 RID: 24708
		[Nullable(2)]
		protected new IJigsawPiece FbInstance;

		// Token: 0x04006085 RID: 24709
		[Nullable(2)]
		protected new IJigsawPiece_SetValue PocoInterface;

		// Token: 0x04006086 RID: 24710
		private IPieceIndex _IndexCache;

		// Token: 0x04006087 RID: 24711
		private bool _IndexInited;
	}
}
