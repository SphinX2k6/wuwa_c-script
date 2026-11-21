using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001575 RID: 5493
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoardOnBtLogicNode
	{
		// Token: 0x06007BC0 RID: 31680 RVA: 0x00126323 File Offset: 0x00124523
		[NullableContext(0)]
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

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x06007BC1 RID: 31681 RVA: 0x00126342 File Offset: 0x00124542
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

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x00126376 File Offset: 0x00124576
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

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x06007BC3 RID: 31683 RVA: 0x001263AA File Offset: 0x001245AA
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

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x06007BC4 RID: 31684 RVA: 0x001263DE File Offset: 0x001245DE
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

		// Token: 0x04004757 RID: 18263
		private ITrackCustomBoardOnBtLogicNode Instance;

		// Token: 0x04004758 RID: 18264
		private IFastReturnMapPos _FastReturnMapPosCache;

		// Token: 0x04004759 RID: 18265
		private bool _FastReturnMapPosInited;

		// Token: 0x0400475A RID: 18266
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x0400475B RID: 18267
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x0400475C RID: 18268
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x0400475D RID: 18269
		private bool _SheriffMainBoardInited;

		// Token: 0x0400475E RID: 18270
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x0400475F RID: 18271
		private bool _SheriffClueDetailBoardInited;
	}
}
