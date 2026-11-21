using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001574 RID: 5492
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoard
	{
		// Token: 0x06007BB6 RID: 31670 RVA: 0x0012615C File Offset: 0x0012435C
		[NullableContext(0)]
		public static ITrackCustomBoard Create(ITrackCustomBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackCustomBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06007BB7 RID: 31671 RVA: 0x0012617B File Offset: 0x0012437B
		public virtual IPhoneMessageBoardConfig TrackPhoneMessageBoard
		{
			get
			{
				if (this._TrackPhoneMessageBoardInited)
				{
					return this._TrackPhoneMessageBoardCache;
				}
				this._TrackPhoneMessageBoardInited = true;
				this._TrackPhoneMessageBoardCache = IPhoneMessageBoardConfig.Create(this.Instance.TrackPhoneMessageBoard);
				return this._TrackPhoneMessageBoardCache;
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x001261AF File Offset: 0x001243AF
		public virtual ITrackQuestBranchBoardConfig TrackQuestBranchBoard
		{
			get
			{
				if (this._TrackQuestBranchBoardInited)
				{
					return this._TrackQuestBranchBoardCache;
				}
				this._TrackQuestBranchBoardInited = true;
				this._TrackQuestBranchBoardCache = ITrackQuestBranchBoardConfig.Create(this.Instance.TrackQuestBranchBoard);
				return this._TrackQuestBranchBoardCache;
			}
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x001261E3 File Offset: 0x001243E3
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

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x06007BBA RID: 31674 RVA: 0x00126217 File Offset: 0x00124417
		public virtual ISheriffReasoningBoardConfig SheriffReasoningBoard
		{
			get
			{
				if (this._SheriffReasoningBoardInited)
				{
					return this._SheriffReasoningBoardCache;
				}
				this._SheriffReasoningBoardInited = true;
				this._SheriffReasoningBoardCache = ISheriffReasoningBoardConfig.Create(this.Instance.SheriffReasoningBoard);
				return this._SheriffReasoningBoardCache;
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x0012624B File Offset: 0x0012444B
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

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x06007BBC RID: 31676 RVA: 0x0012627F File Offset: 0x0012447F
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

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x06007BBD RID: 31677 RVA: 0x001262B3 File Offset: 0x001244B3
		public virtual ITrackReturnDungeon TrackReturnDungeon
		{
			get
			{
				if (this._TrackReturnDungeonInited)
				{
					return this._TrackReturnDungeonCache;
				}
				this._TrackReturnDungeonInited = true;
				this._TrackReturnDungeonCache = ITrackReturnDungeon.Create(this.Instance.TrackReturnDungeon);
				return this._TrackReturnDungeonCache;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x06007BBE RID: 31678 RVA: 0x001262E7 File Offset: 0x001244E7
		public virtual ITrackHandBookBoardConfig TrackHandBookBoard
		{
			get
			{
				if (this._TrackHandBookBoardInited)
				{
					return this._TrackHandBookBoardCache;
				}
				this._TrackHandBookBoardInited = true;
				this._TrackHandBookBoardCache = ITrackHandBookBoardConfig.Create(this.Instance.TrackHandBookBoard);
				return this._TrackHandBookBoardCache;
			}
		}

		// Token: 0x04004746 RID: 18246
		private ITrackCustomBoard Instance;

		// Token: 0x04004747 RID: 18247
		private IPhoneMessageBoardConfig _TrackPhoneMessageBoardCache;

		// Token: 0x04004748 RID: 18248
		private bool _TrackPhoneMessageBoardInited;

		// Token: 0x04004749 RID: 18249
		private ITrackQuestBranchBoardConfig _TrackQuestBranchBoardCache;

		// Token: 0x0400474A RID: 18250
		private bool _TrackQuestBranchBoardInited;

		// Token: 0x0400474B RID: 18251
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x0400474C RID: 18252
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x0400474D RID: 18253
		private ISheriffReasoningBoardConfig _SheriffReasoningBoardCache;

		// Token: 0x0400474E RID: 18254
		private bool _SheriffReasoningBoardInited;

		// Token: 0x0400474F RID: 18255
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x04004750 RID: 18256
		private bool _SheriffMainBoardInited;

		// Token: 0x04004751 RID: 18257
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x04004752 RID: 18258
		private bool _SheriffClueDetailBoardInited;

		// Token: 0x04004753 RID: 18259
		private ITrackReturnDungeon _TrackReturnDungeonCache;

		// Token: 0x04004754 RID: 18260
		private bool _TrackReturnDungeonInited;

		// Token: 0x04004755 RID: 18261
		private ITrackHandBookBoardConfig _TrackHandBookBoardCache;

		// Token: 0x04004756 RID: 18262
		private bool _TrackHandBookBoardInited;
	}
}
