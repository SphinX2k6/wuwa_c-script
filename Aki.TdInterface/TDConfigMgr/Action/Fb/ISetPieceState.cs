using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C57 RID: 11351
	public class ISetPieceState : ISetJigsawFoundationType
	{
		// Token: 0x0600F993 RID: 63891 RVA: 0x00243E2E File Offset: 0x0024202E
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

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x0600F994 RID: 63892 RVA: 0x00243E4D File Offset: 0x0024204D
		public override ESetJigsawFoundationType Type
		{
			get
			{
				return (ESetJigsawFoundationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x0600F995 RID: 63893 RVA: 0x00243E5A File Offset: 0x0024205A
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x0600F996 RID: 63894 RVA: 0x00243E68 File Offset: 0x00242068
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

		// Token: 0x04008867 RID: 34919
		private ISetPieceState Instance;

		// Token: 0x04008868 RID: 34920
		private List<IJigsawPiece> _PieceStateCache;

		// Token: 0x04008869 RID: 34921
		private bool _PieceStateInited;
	}
}
