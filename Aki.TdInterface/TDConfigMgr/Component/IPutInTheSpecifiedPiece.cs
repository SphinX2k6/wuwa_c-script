using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D3 RID: 1747
	public class IPutInTheSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x060024FC RID: 9468 RVA: 0x00064674 File Offset: 0x00062874
		private IPutInTheSpecifiedPiece_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPutInTheSpecifiedPiece 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPutInTheSpecifiedPiece_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPutInTheSpecifiedPiece_SetValue());
			}
			return result;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000646AC File Offset: 0x000628AC
		public static IPutInTheSpecifiedPiece Create([Nullable(2)] IPutInTheSpecifiedPiece instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPutInTheSpecifiedPiece
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000646BF File Offset: 0x000628BF
		public static IPutInTheSpecifiedPiece CreateFromSetValue([Nullable(2)] IPutInTheSpecifiedPiece_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPutInTheSpecifiedPiece
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000646D2 File Offset: 0x000628D2
		public new IPutInTheSpecifiedPiece_SetValue ToSetValue()
		{
			return new IPutInTheSpecifiedPiece_SetValue
			{
				Type = this.Type,
				MatchList = this.MatchList
			};
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000646F1 File Offset: 0x000628F1
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x0006471C File Offset: 0x0006291C
		public override EJigsawCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x0006472C File Offset: 0x0006292C
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x000647BF File Offset: 0x000629BF
		public virtual List<IJigsawPieceMatch> MatchList
		{
			get
			{
				if (this._MatchListInited)
				{
					return this._MatchListCache;
				}
				this._MatchListInited = true;
				if (this.FbInstance != null)
				{
					List<IJigsawPieceMatch> matchList = this.FbInstance.MatchList;
					if (matchList != null)
					{
						this._MatchListCache = new List<IJigsawPieceMatch>(matchList.Count);
						for (int i = 0; i < matchList.Count; i++)
						{
							this._MatchListCache.Add(IJigsawPieceMatch.Create(matchList[i]));
						}
					}
				}
				else
				{
					IPutInTheSpecifiedPiece_SetValue pocoInterface = this.PocoInterface;
					this._MatchListCache = ((pocoInterface != null) ? pocoInterface.MatchList : null);
				}
				return this._MatchListCache;
			}
			set
			{
				this.GetOrCreatePoco().MatchList = value;
				this._MatchListInited = false;
			}
		}

		// Token: 0x04001993 RID: 6547
		[Nullable(2)]
		protected new IPutInTheSpecifiedPiece FbInstance;

		// Token: 0x04001994 RID: 6548
		[Nullable(2)]
		protected new IPutInTheSpecifiedPiece_SetValue PocoInterface;

		// Token: 0x04001995 RID: 6549
		private List<IJigsawPieceMatch> _MatchListCache;

		// Token: 0x04001996 RID: 6550
		private bool _MatchListInited;
	}
}
