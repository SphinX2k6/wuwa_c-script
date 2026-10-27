using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011B0 RID: 4528
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoard
	{
		// Token: 0x060066D4 RID: 26324 RVA: 0x000F644C File Offset: 0x000F464C
		[NullableContext(1)]
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

		// Token: 0x060066D5 RID: 26325 RVA: 0x000F6484 File Offset: 0x000F4684
		[NullableContext(1)]
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

		// Token: 0x060066D6 RID: 26326 RVA: 0x000F6497 File Offset: 0x000F4697
		[NullableContext(1)]
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

		// Token: 0x060066D7 RID: 26327 RVA: 0x000F64AC File Offset: 0x000F46AC
		[NullableContext(1)]
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
				TrackReturnDungeon = this.TrackReturnDungeon
			};
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x060066D8 RID: 26328 RVA: 0x000F6514 File Offset: 0x000F4714
		// (set) Token: 0x060066D9 RID: 26329 RVA: 0x000F6575 File Offset: 0x000F4775
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

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x060066DA RID: 26330 RVA: 0x000F658C File Offset: 0x000F478C
		// (set) Token: 0x060066DB RID: 26331 RVA: 0x000F65ED File Offset: 0x000F47ED
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

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x000F6604 File Offset: 0x000F4804
		// (set) Token: 0x060066DD RID: 26333 RVA: 0x000F6665 File Offset: 0x000F4865
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

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x000F667C File Offset: 0x000F487C
		// (set) Token: 0x060066DF RID: 26335 RVA: 0x000F66DD File Offset: 0x000F48DD
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

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x000F66F4 File Offset: 0x000F48F4
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x000F6755 File Offset: 0x000F4955
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

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x000F676C File Offset: 0x000F496C
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x000F67CD File Offset: 0x000F49CD
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

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x000F67E4 File Offset: 0x000F49E4
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x000F6845 File Offset: 0x000F4A45
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

		// Token: 0x04003DB0 RID: 15792
		protected ITrackCustomBoard FbInstance;

		// Token: 0x04003DB1 RID: 15793
		protected ITrackCustomBoard_SetValue PocoInterface;

		// Token: 0x04003DB2 RID: 15794
		[Nullable(1)]
		private IPhoneMessageBoardConfig _TrackPhoneMessageBoardCache;

		// Token: 0x04003DB3 RID: 15795
		private bool _TrackPhoneMessageBoardInited;

		// Token: 0x04003DB4 RID: 15796
		[Nullable(1)]
		private ITrackQuestBranchBoardConfig _TrackQuestBranchBoardCache;

		// Token: 0x04003DB5 RID: 15797
		private bool _TrackQuestBranchBoardInited;

		// Token: 0x04003DB6 RID: 15798
		[Nullable(1)]
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x04003DB7 RID: 15799
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x04003DB8 RID: 15800
		[Nullable(1)]
		private ISheriffReasoningBoardConfig _SheriffReasoningBoardCache;

		// Token: 0x04003DB9 RID: 15801
		private bool _SheriffReasoningBoardInited;

		// Token: 0x04003DBA RID: 15802
		[Nullable(1)]
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x04003DBB RID: 15803
		private bool _SheriffMainBoardInited;

		// Token: 0x04003DBC RID: 15804
		[Nullable(1)]
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x04003DBD RID: 15805
		private bool _SheriffClueDetailBoardInited;

		// Token: 0x04003DBE RID: 15806
		[Nullable(1)]
		private ITrackReturnDungeon _TrackReturnDungeonCache;

		// Token: 0x04003DBF RID: 15807
		private bool _TrackReturnDungeonInited;
	}
}
