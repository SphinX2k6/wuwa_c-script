using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002972 RID: 10610
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetPieceState : ISetJigsawFoundationType
	{
		// Token: 0x0600EB1D RID: 60189 RVA: 0x00226776 File Offset: 0x00224976
		public static ISetPieceState Create(ISetPieceState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetPieceState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x0600EB1E RID: 60190 RVA: 0x00226795 File Offset: 0x00224995
		public override ESetJigsawFoundationType Type
		{
			get
			{
				return (ESetJigsawFoundationType)this.Instance.Type;
			}
		}

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x0600EB1F RID: 60191 RVA: 0x002267A2 File Offset: 0x002249A2
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x0600EB20 RID: 60192 RVA: 0x002267B0 File Offset: 0x002249B0
		public virtual List<IJigsawPiece> PieceState
		{
			get
			{
				if (this._PieceStateInited)
				{
					return this._PieceStateCache;
				}
				this._PieceStateInited = true;
				int pieceStateLength = this.Instance.PieceStateLength;
				this._PieceStateCache = new List<IJigsawPiece>(pieceStateLength);
				for (int i = 0; i < pieceStateLength; i++)
				{
					this._PieceStateCache.Add(IJigsawPiece.Create(this.Instance.PieceState(i)));
				}
				return this._PieceStateCache;
			}
		}

		// Token: 0x04008186 RID: 33158
		private ISetPieceState Instance;

		// Token: 0x04008187 RID: 33159
		private List<IJigsawPiece> _PieceStateCache;

		// Token: 0x04008188 RID: 33160
		private bool _PieceStateInited;
	}
}
