using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6A RID: 7018
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawPiece : IPieceBase
	{
		// Token: 0x0600964D RID: 38477 RVA: 0x0015B428 File Offset: 0x00159628
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

		// Token: 0x0600964E RID: 38478 RVA: 0x0015B460 File Offset: 0x00159660
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

		// Token: 0x0600964F RID: 38479 RVA: 0x0015B473 File Offset: 0x00159673
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

		// Token: 0x06009650 RID: 38480 RVA: 0x0015B486 File Offset: 0x00159686
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

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x0015B4C0 File Offset: 0x001596C0
		// (set) Token: 0x06009652 RID: 38482 RVA: 0x0015B521 File Offset: 0x00159721
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

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x06009653 RID: 38483 RVA: 0x0015B536 File Offset: 0x00159736
		// (set) Token: 0x06009654 RID: 38484 RVA: 0x0015B561 File Offset: 0x00159761
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

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x06009655 RID: 38485 RVA: 0x0015B56F File Offset: 0x0015976F
		// (set) Token: 0x06009656 RID: 38486 RVA: 0x0015B59A File Offset: 0x0015979A
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

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x06009657 RID: 38487 RVA: 0x0015B5A8 File Offset: 0x001597A8
		// (set) Token: 0x06009658 RID: 38488 RVA: 0x0015B5D3 File Offset: 0x001597D3
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

		// Token: 0x04005BEB RID: 23531
		[Nullable(2)]
		protected new IJigsawPiece FbInstance;

		// Token: 0x04005BEC RID: 23532
		[Nullable(2)]
		protected new IJigsawPiece_SetValue PocoInterface;

		// Token: 0x04005BED RID: 23533
		private IPieceIndex _IndexCache;

		// Token: 0x04005BEE RID: 23534
		private bool _IndexInited;
	}
}
