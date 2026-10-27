using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141D RID: 5149
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoardOnBtLogicNode
	{
		// Token: 0x060074FB RID: 29947 RVA: 0x001178D7 File Offset: 0x00115AD7
		[NullableContext(1)]
		public static ITrackCustomBoardOnBtLogicNode Create(ITrackCustomBoardOnBtLogicNode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackCustomBoardOnBtLogicNode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x001178F6 File Offset: 0x00115AF6
		public virtual IFastReturnMapPos FastReturnMapPos
		{
			get
			{
				if (this._FastReturnMapPosInited)
				{
					return this._FastReturnMapPosCache;
				}
				this._FastReturnMapPosInited = true;
				this._FastReturnMapPosCache = IFastReturnMapPos.Create(this.Instance.FastReturnMapPos);
				return this._FastReturnMapPosCache;
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x060074FD RID: 29949 RVA: 0x0011792A File Offset: 0x00115B2A
		public virtual ISheriffAnomalyProgressBoardConfig SheriffAnomalyProgressBoard
		{
			get
			{
				if (this._SheriffAnomalyProgressBoardInited)
				{
					return this._SheriffAnomalyProgressBoardCache;
				}
				this._SheriffAnomalyProgressBoardInited = true;
				this._SheriffAnomalyProgressBoardCache = ISheriffAnomalyProgressBoardConfig.Create(this.Instance.SheriffAnomalyProgressBoard);
				return this._SheriffAnomalyProgressBoardCache;
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x060074FE RID: 29950 RVA: 0x0011795E File Offset: 0x00115B5E
		public virtual ISheriffMainBoardConfig SheriffMainBoard
		{
			get
			{
				if (this._SheriffMainBoardInited)
				{
					return this._SheriffMainBoardCache;
				}
				this._SheriffMainBoardInited = true;
				this._SheriffMainBoardCache = ISheriffMainBoardConfig.Create(this.Instance.SheriffMainBoard);
				return this._SheriffMainBoardCache;
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x00117992 File Offset: 0x00115B92
		public virtual ISheriffClueDetailBoardConfig SheriffClueDetailBoard
		{
			get
			{
				if (this._SheriffClueDetailBoardInited)
				{
					return this._SheriffClueDetailBoardCache;
				}
				this._SheriffClueDetailBoardInited = true;
				this._SheriffClueDetailBoardCache = ISheriffClueDetailBoardConfig.Create(this.Instance.SheriffClueDetailBoard);
				return this._SheriffClueDetailBoardCache;
			}
		}

		// Token: 0x040043C3 RID: 17347
		private ITrackCustomBoardOnBtLogicNode Instance;

		// Token: 0x040043C4 RID: 17348
		private IFastReturnMapPos _FastReturnMapPosCache;

		// Token: 0x040043C5 RID: 17349
		private bool _FastReturnMapPosInited;

		// Token: 0x040043C6 RID: 17350
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x040043C7 RID: 17351
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x040043C8 RID: 17352
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x040043C9 RID: 17353
		private bool _SheriffMainBoardInited;

		// Token: 0x040043CA RID: 17354
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x040043CB RID: 17355
		private bool _SheriffClueDetailBoardInited;
	}
}
