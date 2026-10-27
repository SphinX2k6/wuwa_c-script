using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000636 RID: 1590
	[NullableContext(1)]
	[Nullable(0)]
	public class IPutInTheSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x0005D960 File Offset: 0x0005BB60
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

		// Token: 0x060021F7 RID: 8695 RVA: 0x0005D998 File Offset: 0x0005BB98
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

		// Token: 0x060021F8 RID: 8696 RVA: 0x0005D9AB File Offset: 0x0005BBAB
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

		// Token: 0x060021F9 RID: 8697 RVA: 0x0005D9BE File Offset: 0x0005BBBE
		public new IPutInTheSpecifiedPiece_SetValue ToSetValue()
		{
			return new IPutInTheSpecifiedPiece_SetValue
			{
				Type = this.Type,
				MatchList = this.MatchList
			};
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0005D9DD File Offset: 0x0005BBDD
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x0005DA08 File Offset: 0x0005BC08
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x0005DA18 File Offset: 0x0005BC18
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x0005DAAB File Offset: 0x0005BCAB
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

		// Token: 0x040017A1 RID: 6049
		[Nullable(2)]
		protected new IPutInTheSpecifiedPiece FbInstance;

		// Token: 0x040017A2 RID: 6050
		[Nullable(2)]
		protected new IPutInTheSpecifiedPiece_SetValue PocoInterface;

		// Token: 0x040017A3 RID: 6051
		private List<IJigsawPieceMatch> _MatchListCache;

		// Token: 0x040017A4 RID: 6052
		private bool _MatchListInited;
	}
}
