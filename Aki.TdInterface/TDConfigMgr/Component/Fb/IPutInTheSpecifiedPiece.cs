using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D71 RID: 3441
	public class IPutInTheSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004E36 RID: 20022 RVA: 0x000C2DAD File Offset: 0x000C0FAD
		public static IPutInTheSpecifiedPiece Create(IPutInTheSpecifiedPiece? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPutInTheSpecifiedPiece
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06004E37 RID: 20023 RVA: 0x000C2DCC File Offset: 0x000C0FCC
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x000C2DDC File Offset: 0x000C0FDC
		public virtual List<IJigsawPieceMatch> MatchList
		{
			get
			{
				if (this._MatchListInited)
				{
					return this._MatchListCache;
				}
				this._MatchListInited = true;
				int matchListLength = this.Instance.MatchListLength;
				this._MatchListCache = new List<IJigsawPieceMatch>(matchListLength);
				for (int i = 0; i < matchListLength; i++)
				{
					this._MatchListCache.Add(IJigsawPieceMatch.Create(this.Instance.MatchList(i)));
				}
				return this._MatchListCache;
			}
		}

		// Token: 0x04002C68 RID: 11368
		private IPutInTheSpecifiedPiece Instance;

		// Token: 0x04002C69 RID: 11369
		private List<IJigsawPieceMatch> _MatchListCache;

		// Token: 0x04002C6A RID: 11370
		private bool _MatchListInited;
	}
}
