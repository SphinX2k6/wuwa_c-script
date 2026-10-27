using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3C RID: 7740
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetPieceState : ISetJigsawFoundationType
	{
		// Token: 0x0600A59D RID: 42397 RVA: 0x00177204 File Offset: 0x00175404
		private ISetPieceState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetPieceState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetPieceState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetPieceState_SetValue());
			}
			return result;
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x0017723C File Offset: 0x0017543C
		public static ISetPieceState Create([Nullable(2)] ISetPieceState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetPieceState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x0017724F File Offset: 0x0017544F
		public static ISetPieceState CreateFromSetValue([Nullable(2)] ISetPieceState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetPieceState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x00177262 File Offset: 0x00175462
		public new ISetPieceState_SetValue ToSetValue()
		{
			return new ISetPieceState_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PieceState = this.PieceState
			};
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A5A1 RID: 42401 RVA: 0x0017728D File Offset: 0x0017548D
		// (set) Token: 0x0600A5A2 RID: 42402 RVA: 0x001772B8 File Offset: 0x001754B8
		public override ESetJigsawFoundationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600A5A3 RID: 42403 RVA: 0x001772C6 File Offset: 0x001754C6
		// (set) Token: 0x0600A5A4 RID: 42404 RVA: 0x001772F1 File Offset: 0x001754F1
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

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600A5A5 RID: 42405 RVA: 0x00177300 File Offset: 0x00175500
		// (set) Token: 0x0600A5A6 RID: 42406 RVA: 0x00177393 File Offset: 0x00175593
		public virtual List<IJigsawPiece> PieceState
		{
			get
			{
				if (this._PieceStateInited)
				{
					return this._PieceStateCache;
				}
				this._PieceStateInited = true;
				if (this.FbInstance != null)
				{
					List<IJigsawPiece> pieceState = this.FbInstance.PieceState;
					if (pieceState != null)
					{
						this._PieceStateCache = new List<IJigsawPiece>(pieceState.Count);
						for (int i = 0; i < pieceState.Count; i++)
						{
							this._PieceStateCache.Add(IJigsawPiece.Create(pieceState[i]));
						}
					}
				}
				else
				{
					ISetPieceState_SetValue pocoInterface = this.PocoInterface;
					this._PieceStateCache = ((pocoInterface != null) ? pocoInterface.PieceState : null);
				}
				return this._PieceStateCache;
			}
			set
			{
				this.GetOrCreatePoco().PieceState = value;
				this._PieceStateInited = false;
			}
		}

		// Token: 0x04006306 RID: 25350
		[Nullable(2)]
		protected new ISetPieceState FbInstance;

		// Token: 0x04006307 RID: 25351
		[Nullable(2)]
		protected new ISetPieceState_SetValue PocoInterface;

		// Token: 0x04006308 RID: 25352
		private List<IJigsawPiece> _PieceStateCache;

		// Token: 0x04006309 RID: 25353
		private bool _PieceStateInited;
	}
}
