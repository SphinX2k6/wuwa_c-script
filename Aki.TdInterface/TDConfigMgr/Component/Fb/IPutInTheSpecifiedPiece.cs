using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8F RID: 3215
	[NullableContext(1)]
	[Nullable(0)]
	public class IPutInTheSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004988 RID: 18824 RVA: 0x000B839D File Offset: 0x000B659D
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

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x000B83BC File Offset: 0x000B65BC
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x000B83CC File Offset: 0x000B65CC
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

		// Token: 0x040029EE RID: 10734
		private IPutInTheSpecifiedPiece Instance;

		// Token: 0x040029EF RID: 10735
		private List<IJigsawPieceMatch> _MatchListCache;

		// Token: 0x040029F0 RID: 10736
		private bool _MatchListInited;
	}
}
