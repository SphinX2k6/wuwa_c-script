using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012EA RID: 4842
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoard
	{
		// Token: 0x06006D0B RID: 27915 RVA: 0x00103C18 File Offset: 0x00101E18
		[NullableContext(0)]
		private ITrackCustomBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackCustomBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackCustomBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackCustomBoard_SetValue());
			}
			return result;
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x00103C50 File Offset: 0x00101E50
		[NullableContext(0)]
		public static ITrackCustomBoard Create([Nullable(2)] ITrackCustomBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackCustomBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x00103C63 File Offset: 0x00101E63
		[NullableContext(0)]
		public static ITrackCustomBoard CreateFromSetValue([Nullable(2)] ITrackCustomBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackCustomBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00103C78 File Offset: 0x00101E78
		[NullableContext(0)]
		public ITrackCustomBoard_SetValue ToSetValue()
		{
			return new ITrackCustomBoard_SetValue
			{
				TrackPhoneMessageBoard = this.TrackPhoneMessageBoard,
				TrackQuestBranchBoard = this.TrackQuestBranchBoard,
				SheriffAnomalyProgressBoard = this.SheriffAnomalyProgressBoard,
				SheriffReasoningBoard = this.SheriffReasoningBoard,
				SheriffMainBoard = this.SheriffMainBoard,
				SheriffClueDetailBoard = this.SheriffClueDetailBoard,
				TrackReturnDungeon = this.TrackReturnDungeon,
				TrackHandBookBoard = this.TrackHandBookBoard
			};
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x00103CEC File Offset: 0x00101EEC
		// (set) Token: 0x06006D10 RID: 27920 RVA: 0x00103D4D File Offset: 0x00101F4D
		public virtual IPhoneMessageBoardConfig TrackPhoneMessageBoard
		{
			get
			{
				if (this._TrackPhoneMessageBoardInited)
				{
					return this._TrackPhoneMessageBoardCache;
				}
				this._TrackPhoneMessageBoardInited = true;
				if (this.FbInstance != null)
				{
					this._TrackPhoneMessageBoardCache = IPhoneMessageBoardConfig.Create(this.FbInstance.TrackPhoneMessageBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._TrackPhoneMessageBoardCache = ((pocoInterface != null) ? pocoInterface.TrackPhoneMessageBoard : null);
				}
				return this._TrackPhoneMessageBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().TrackPhoneMessageBoard = value;
				this._TrackPhoneMessageBoardInited = false;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x00103D64 File Offset: 0x00101F64
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x00103DC5 File Offset: 0x00101FC5
		public virtual ITrackQuestBranchBoardConfig TrackQuestBranchBoard
		{
			get
			{
				if (this._TrackQuestBranchBoardInited)
				{
					return this._TrackQuestBranchBoardCache;
				}
				this._TrackQuestBranchBoardInited = true;
				if (this.FbInstance != null)
				{
					this._TrackQuestBranchBoardCache = ITrackQuestBranchBoardConfig.Create(this.FbInstance.TrackQuestBranchBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._TrackQuestBranchBoardCache = ((pocoInterface != null) ? pocoInterface.TrackQuestBranchBoard : null);
				}
				return this._TrackQuestBranchBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().TrackQuestBranchBoard = value;
				this._TrackQuestBranchBoardInited = false;
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x00103DDC File Offset: 0x00101FDC
		// (set) Token: 0x06006D14 RID: 27924 RVA: 0x00103E3D File Offset: 0x0010203D
		public virtual ISheriffAnomalyProgressBoardConfig SheriffAnomalyProgressBoard
		{
			get
			{
				if (this._SheriffAnomalyProgressBoardInited)
				{
					return this._SheriffAnomalyProgressBoardCache;
				}
				this._SheriffAnomalyProgressBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffAnomalyProgressBoardCache = ISheriffAnomalyProgressBoardConfig.Create(this.FbInstance.SheriffAnomalyProgressBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._SheriffAnomalyProgressBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffAnomalyProgressBoard : null);
				}
				return this._SheriffAnomalyProgressBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffAnomalyProgressBoard = value;
				this._SheriffAnomalyProgressBoardInited = false;
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x00103E54 File Offset: 0x00102054
		// (set) Token: 0x06006D16 RID: 27926 RVA: 0x00103EB5 File Offset: 0x001020B5
		public virtual ISheriffReasoningBoardConfig SheriffReasoningBoard
		{
			get
			{
				if (this._SheriffReasoningBoardInited)
				{
					return this._SheriffReasoningBoardCache;
				}
				this._SheriffReasoningBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffReasoningBoardCache = ISheriffReasoningBoardConfig.Create(this.FbInstance.SheriffReasoningBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._SheriffReasoningBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffReasoningBoard : null);
				}
				return this._SheriffReasoningBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffReasoningBoard = value;
				this._SheriffReasoningBoardInited = false;
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x00103ECC File Offset: 0x001020CC
		// (set) Token: 0x06006D18 RID: 27928 RVA: 0x00103F2D File Offset: 0x0010212D
		public virtual ISheriffMainBoardConfig SheriffMainBoard
		{
			get
			{
				if (this._SheriffMainBoardInited)
				{
					return this._SheriffMainBoardCache;
				}
				this._SheriffMainBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffMainBoardCache = ISheriffMainBoardConfig.Create(this.FbInstance.SheriffMainBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._SheriffMainBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffMainBoard : null);
				}
				return this._SheriffMainBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffMainBoard = value;
				this._SheriffMainBoardInited = false;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x00103F44 File Offset: 0x00102144
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x00103FA5 File Offset: 0x001021A5
		public virtual ISheriffClueDetailBoardConfig SheriffClueDetailBoard
		{
			get
			{
				if (this._SheriffClueDetailBoardInited)
				{
					return this._SheriffClueDetailBoardCache;
				}
				this._SheriffClueDetailBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffClueDetailBoardCache = ISheriffClueDetailBoardConfig.Create(this.FbInstance.SheriffClueDetailBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._SheriffClueDetailBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffClueDetailBoard : null);
				}
				return this._SheriffClueDetailBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffClueDetailBoard = value;
				this._SheriffClueDetailBoardInited = false;
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x00103FBC File Offset: 0x001021BC
		// (set) Token: 0x06006D1C RID: 27932 RVA: 0x0010401D File Offset: 0x0010221D
		public virtual ITrackReturnDungeon TrackReturnDungeon
		{
			get
			{
				if (this._TrackReturnDungeonInited)
				{
					return this._TrackReturnDungeonCache;
				}
				this._TrackReturnDungeonInited = true;
				if (this.FbInstance != null)
				{
					this._TrackReturnDungeonCache = ITrackReturnDungeon.Create(this.FbInstance.TrackReturnDungeon);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._TrackReturnDungeonCache = ((pocoInterface != null) ? pocoInterface.TrackReturnDungeon : null);
				}
				return this._TrackReturnDungeonCache;
			}
			set
			{
				this.GetOrCreatePoco().TrackReturnDungeon = value;
				this._TrackReturnDungeonInited = false;
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x00104034 File Offset: 0x00102234
		// (set) Token: 0x06006D1E RID: 27934 RVA: 0x00104095 File Offset: 0x00102295
		public virtual ITrackHandBookBoardConfig TrackHandBookBoard
		{
			get
			{
				if (this._TrackHandBookBoardInited)
				{
					return this._TrackHandBookBoardCache;
				}
				this._TrackHandBookBoardInited = true;
				if (this.FbInstance != null)
				{
					this._TrackHandBookBoardCache = ITrackHandBookBoardConfig.Create(this.FbInstance.TrackHandBookBoard);
				}
				else
				{
					ITrackCustomBoard_SetValue pocoInterface = this.PocoInterface;
					this._TrackHandBookBoardCache = ((pocoInterface != null) ? pocoInterface.TrackHandBookBoard : null);
				}
				return this._TrackHandBookBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().TrackHandBookBoard = value;
				this._TrackHandBookBoardInited = false;
			}
		}

		// Token: 0x04004118 RID: 16664
		protected ITrackCustomBoard FbInstance;

		// Token: 0x04004119 RID: 16665
		protected ITrackCustomBoard_SetValue PocoInterface;

		// Token: 0x0400411A RID: 16666
		[Nullable(0)]
		private IPhoneMessageBoardConfig _TrackPhoneMessageBoardCache;

		// Token: 0x0400411B RID: 16667
		private bool _TrackPhoneMessageBoardInited;

		// Token: 0x0400411C RID: 16668
		[Nullable(0)]
		private ITrackQuestBranchBoardConfig _TrackQuestBranchBoardCache;

		// Token: 0x0400411D RID: 16669
		private bool _TrackQuestBranchBoardInited;

		// Token: 0x0400411E RID: 16670
		[Nullable(0)]
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x0400411F RID: 16671
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x04004120 RID: 16672
		[Nullable(0)]
		private ISheriffReasoningBoardConfig _SheriffReasoningBoardCache;

		// Token: 0x04004121 RID: 16673
		private bool _SheriffReasoningBoardInited;

		// Token: 0x04004122 RID: 16674
		[Nullable(0)]
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x04004123 RID: 16675
		private bool _SheriffMainBoardInited;

		// Token: 0x04004124 RID: 16676
		[Nullable(0)]
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x04004125 RID: 16677
		private bool _SheriffClueDetailBoardInited;

		// Token: 0x04004126 RID: 16678
		[Nullable(0)]
		private ITrackReturnDungeon _TrackReturnDungeonCache;

		// Token: 0x04004127 RID: 16679
		private bool _TrackReturnDungeonInited;

		// Token: 0x04004128 RID: 16680
		[Nullable(0)]
		private ITrackHandBookBoardConfig _TrackHandBookBoardCache;

		// Token: 0x04004129 RID: 16681
		private bool _TrackHandBookBoardInited;
	}
}
