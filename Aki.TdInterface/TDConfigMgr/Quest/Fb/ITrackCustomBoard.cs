using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141C RID: 5148
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoard
	{
		// Token: 0x060074F2 RID: 29938 RVA: 0x00117744 File Offset: 0x00115944
		[NullableContext(1)]
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

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x00117763 File Offset: 0x00115963
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

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x00117797 File Offset: 0x00115997
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

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x060074F5 RID: 29941 RVA: 0x001177CB File Offset: 0x001159CB
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

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x060074F6 RID: 29942 RVA: 0x001177FF File Offset: 0x001159FF
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

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x060074F7 RID: 29943 RVA: 0x00117833 File Offset: 0x00115A33
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

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x060074F8 RID: 29944 RVA: 0x00117867 File Offset: 0x00115A67
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

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x060074F9 RID: 29945 RVA: 0x0011789B File Offset: 0x00115A9B
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

		// Token: 0x040043B4 RID: 17332
		private ITrackCustomBoard Instance;

		// Token: 0x040043B5 RID: 17333
		private IPhoneMessageBoardConfig _TrackPhoneMessageBoardCache;

		// Token: 0x040043B6 RID: 17334
		private bool _TrackPhoneMessageBoardInited;

		// Token: 0x040043B7 RID: 17335
		private ITrackQuestBranchBoardConfig _TrackQuestBranchBoardCache;

		// Token: 0x040043B8 RID: 17336
		private bool _TrackQuestBranchBoardInited;

		// Token: 0x040043B9 RID: 17337
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x040043BA RID: 17338
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x040043BB RID: 17339
		private ISheriffReasoningBoardConfig _SheriffReasoningBoardCache;

		// Token: 0x040043BC RID: 17340
		private bool _SheriffReasoningBoardInited;

		// Token: 0x040043BD RID: 17341
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x040043BE RID: 17342
		private bool _SheriffMainBoardInited;

		// Token: 0x040043BF RID: 17343
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x040043C0 RID: 17344
		private bool _SheriffClueDetailBoardInited;

		// Token: 0x040043C1 RID: 17345
		private ITrackReturnDungeon _TrackReturnDungeonCache;

		// Token: 0x040043C2 RID: 17346
		private bool _TrackReturnDungeonInited;
	}
}
