using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004646 RID: 17990
	public struct ITrackCustomBoard : IFlatbufferObject
	{
		// Token: 0x17007DE8 RID: 32232
		// (get) Token: 0x0601A590 RID: 107920 RVA: 0x003BFFAE File Offset: 0x003BE1AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A591 RID: 107921 RVA: 0x003BFFBB File Offset: 0x003BE1BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A592 RID: 107922 RVA: 0x003BFFC4 File Offset: 0x003BE1C4
		public static ITrackCustomBoard GetRootAsITrackCustomBoard(ByteBuffer _bb)
		{
			return ITrackCustomBoard.GetRootAsITrackCustomBoard(_bb, default(ITrackCustomBoard));
		}

		// Token: 0x0601A593 RID: 107923 RVA: 0x003BFFE0 File Offset: 0x003BE1E0
		public static ITrackCustomBoard GetRootAsITrackCustomBoard(ByteBuffer _bb, ITrackCustomBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A594 RID: 107924 RVA: 0x003BFFFD File Offset: 0x003BE1FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A595 RID: 107925 RVA: 0x003C000C File Offset: 0x003BE20C
		public ITrackCustomBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DE9 RID: 32233
		// (get) Token: 0x0601A596 RID: 107926 RVA: 0x003C001C File Offset: 0x003BE21C
		public IPhoneMessageBoardConfig? TrackPhoneMessageBoard
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPhoneMessageBoardConfig?(default(IPhoneMessageBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DEA RID: 32234
		// (get) Token: 0x0601A597 RID: 107927 RVA: 0x003C007C File Offset: 0x003BE27C
		public ITrackQuestBranchBoardConfig? TrackQuestBranchBoard
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITrackQuestBranchBoardConfig?(default(ITrackQuestBranchBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DEB RID: 32235
		// (get) Token: 0x0601A598 RID: 107928 RVA: 0x003C00DC File Offset: 0x003BE2DC
		public ISheriffAnomalyProgressBoardConfig? SheriffAnomalyProgressBoard
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffAnomalyProgressBoardConfig?(default(ISheriffAnomalyProgressBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DEC RID: 32236
		// (get) Token: 0x0601A599 RID: 107929 RVA: 0x003C013C File Offset: 0x003BE33C
		public ISheriffReasoningBoardConfig? SheriffReasoningBoard
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffReasoningBoardConfig?(default(ISheriffReasoningBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DED RID: 32237
		// (get) Token: 0x0601A59A RID: 107930 RVA: 0x003C019C File Offset: 0x003BE39C
		public ISheriffMainBoardConfig? SheriffMainBoard
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffMainBoardConfig?(default(ISheriffMainBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DEE RID: 32238
		// (get) Token: 0x0601A59B RID: 107931 RVA: 0x003C01FC File Offset: 0x003BE3FC
		public ISheriffClueDetailBoardConfig? SheriffClueDetailBoard
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffClueDetailBoardConfig?(default(ISheriffClueDetailBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DEF RID: 32239
		// (get) Token: 0x0601A59C RID: 107932 RVA: 0x003C025C File Offset: 0x003BE45C
		public ITrackReturnDungeon? TrackReturnDungeon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ITrackReturnDungeon?(default(ITrackReturnDungeon).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DF0 RID: 32240
		// (get) Token: 0x0601A59D RID: 107933 RVA: 0x003C02BC File Offset: 0x003BE4BC
		public ITrackHandBookBoardConfig? TrackHandBookBoard
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ITrackHandBookBoardConfig?(default(ITrackHandBookBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A59E RID: 107934 RVA: 0x003C031C File Offset: 0x003BE51C
		public static Offset<ITrackCustomBoard> CreateITrackCustomBoard(FlatBufferBuilder builder, Offset<IPhoneMessageBoardConfig> TrackPhoneMessageBoardOffset = default(Offset<IPhoneMessageBoardConfig>), Offset<ITrackQuestBranchBoardConfig> TrackQuestBranchBoardOffset = default(Offset<ITrackQuestBranchBoardConfig>), Offset<ISheriffAnomalyProgressBoardConfig> SheriffAnomalyProgressBoardOffset = default(Offset<ISheriffAnomalyProgressBoardConfig>), Offset<ISheriffReasoningBoardConfig> SheriffReasoningBoardOffset = default(Offset<ISheriffReasoningBoardConfig>), Offset<ISheriffMainBoardConfig> SheriffMainBoardOffset = default(Offset<ISheriffMainBoardConfig>), Offset<ISheriffClueDetailBoardConfig> SheriffClueDetailBoardOffset = default(Offset<ISheriffClueDetailBoardConfig>), Offset<ITrackReturnDungeon> TrackReturnDungeonOffset = default(Offset<ITrackReturnDungeon>), Offset<ITrackHandBookBoardConfig> TrackHandBookBoardOffset = default(Offset<ITrackHandBookBoardConfig>))
		{
			builder.StartTable(8);
			ITrackCustomBoard.AddTrackHandBookBoard(builder, TrackHandBookBoardOffset);
			ITrackCustomBoard.AddTrackReturnDungeon(builder, TrackReturnDungeonOffset);
			ITrackCustomBoard.AddSheriffClueDetailBoard(builder, SheriffClueDetailBoardOffset);
			ITrackCustomBoard.AddSheriffMainBoard(builder, SheriffMainBoardOffset);
			ITrackCustomBoard.AddSheriffReasoningBoard(builder, SheriffReasoningBoardOffset);
			ITrackCustomBoard.AddSheriffAnomalyProgressBoard(builder, SheriffAnomalyProgressBoardOffset);
			ITrackCustomBoard.AddTrackQuestBranchBoard(builder, TrackQuestBranchBoardOffset);
			ITrackCustomBoard.AddTrackPhoneMessageBoard(builder, TrackPhoneMessageBoardOffset);
			return ITrackCustomBoard.EndITrackCustomBoard(builder);
		}

		// Token: 0x0601A59F RID: 107935 RVA: 0x003C0373 File Offset: 0x003BE573
		public static void StartITrackCustomBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601A5A0 RID: 107936 RVA: 0x003C037C File Offset: 0x003BE57C
		public static void AddTrackPhoneMessageBoard(FlatBufferBuilder builder, Offset<IPhoneMessageBoardConfig> trackPhoneMessageBoardOffset)
		{
			builder.AddOffset(0, trackPhoneMessageBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A1 RID: 107937 RVA: 0x003C038C File Offset: 0x003BE58C
		public static void AddTrackQuestBranchBoard(FlatBufferBuilder builder, Offset<ITrackQuestBranchBoardConfig> trackQuestBranchBoardOffset)
		{
			builder.AddOffset(1, trackQuestBranchBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A2 RID: 107938 RVA: 0x003C039C File Offset: 0x003BE59C
		public static void AddSheriffAnomalyProgressBoard(FlatBufferBuilder builder, Offset<ISheriffAnomalyProgressBoardConfig> sheriffAnomalyProgressBoardOffset)
		{
			builder.AddOffset(2, sheriffAnomalyProgressBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A3 RID: 107939 RVA: 0x003C03AC File Offset: 0x003BE5AC
		public static void AddSheriffReasoningBoard(FlatBufferBuilder builder, Offset<ISheriffReasoningBoardConfig> sheriffReasoningBoardOffset)
		{
			builder.AddOffset(3, sheriffReasoningBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A4 RID: 107940 RVA: 0x003C03BC File Offset: 0x003BE5BC
		public static void AddSheriffMainBoard(FlatBufferBuilder builder, Offset<ISheriffMainBoardConfig> sheriffMainBoardOffset)
		{
			builder.AddOffset(4, sheriffMainBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A5 RID: 107941 RVA: 0x003C03CC File Offset: 0x003BE5CC
		public static void AddSheriffClueDetailBoard(FlatBufferBuilder builder, Offset<ISheriffClueDetailBoardConfig> sheriffClueDetailBoardOffset)
		{
			builder.AddOffset(5, sheriffClueDetailBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A6 RID: 107942 RVA: 0x003C03DC File Offset: 0x003BE5DC
		public static void AddTrackReturnDungeon(FlatBufferBuilder builder, Offset<ITrackReturnDungeon> trackReturnDungeonOffset)
		{
			builder.AddOffset(6, trackReturnDungeonOffset.Value, 0);
		}

		// Token: 0x0601A5A7 RID: 107943 RVA: 0x003C03EC File Offset: 0x003BE5EC
		public static void AddTrackHandBookBoard(FlatBufferBuilder builder, Offset<ITrackHandBookBoardConfig> trackHandBookBoardOffset)
		{
			builder.AddOffset(7, trackHandBookBoardOffset.Value, 0);
		}

		// Token: 0x0601A5A8 RID: 107944 RVA: 0x003C03FC File Offset: 0x003BE5FC
		public static Offset<ITrackCustomBoard> EndITrackCustomBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITrackCustomBoard>(builder.EndTable());
		}

		// Token: 0x0601A5A9 RID: 107945 RVA: 0x003C040C File Offset: 0x003BE60C
		public ITrackCustomBoardT UnPack()
		{
			ITrackCustomBoardT trackCustomBoardT = new ITrackCustomBoardT();
			this.UnPackTo(trackCustomBoardT);
			return trackCustomBoardT;
		}

		// Token: 0x0601A5AA RID: 107946 RVA: 0x003C0428 File Offset: 0x003BE628
		public void UnPackTo(ITrackCustomBoardT _o)
		{
			_o.TrackPhoneMessageBoard = ((this.TrackPhoneMessageBoard != null) ? this.TrackPhoneMessageBoard.Value.UnPack() : null);
			_o.TrackQuestBranchBoard = ((this.TrackQuestBranchBoard != null) ? this.TrackQuestBranchBoard.Value.UnPack() : null);
			_o.SheriffAnomalyProgressBoard = ((this.SheriffAnomalyProgressBoard != null) ? this.SheriffAnomalyProgressBoard.Value.UnPack() : null);
			_o.SheriffReasoningBoard = ((this.SheriffReasoningBoard != null) ? this.SheriffReasoningBoard.Value.UnPack() : null);
			_o.SheriffMainBoard = ((this.SheriffMainBoard != null) ? this.SheriffMainBoard.Value.UnPack() : null);
			_o.SheriffClueDetailBoard = ((this.SheriffClueDetailBoard != null) ? this.SheriffClueDetailBoard.Value.UnPack() : null);
			_o.TrackReturnDungeon = ((this.TrackReturnDungeon != null) ? this.TrackReturnDungeon.Value.UnPack() : null);
			_o.TrackHandBookBoard = ((this.TrackHandBookBoard != null) ? this.TrackHandBookBoard.Value.UnPack() : null);
		}

		// Token: 0x0601A5AB RID: 107947 RVA: 0x003C05C0 File Offset: 0x003BE7C0
		public static Offset<ITrackCustomBoard> Pack(FlatBufferBuilder builder, ITrackCustomBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackCustomBoard>);
			}
			Offset<IPhoneMessageBoardConfig> trackPhoneMessageBoardOffset = (_o.TrackPhoneMessageBoard == null) ? default(Offset<IPhoneMessageBoardConfig>) : IPhoneMessageBoardConfig.Pack(builder, _o.TrackPhoneMessageBoard);
			Offset<ITrackQuestBranchBoardConfig> trackQuestBranchBoardOffset = (_o.TrackQuestBranchBoard == null) ? default(Offset<ITrackQuestBranchBoardConfig>) : ITrackQuestBranchBoardConfig.Pack(builder, _o.TrackQuestBranchBoard);
			Offset<ISheriffAnomalyProgressBoardConfig> sheriffAnomalyProgressBoardOffset = (_o.SheriffAnomalyProgressBoard == null) ? default(Offset<ISheriffAnomalyProgressBoardConfig>) : ISheriffAnomalyProgressBoardConfig.Pack(builder, _o.SheriffAnomalyProgressBoard);
			Offset<ISheriffReasoningBoardConfig> sheriffReasoningBoardOffset = (_o.SheriffReasoningBoard == null) ? default(Offset<ISheriffReasoningBoardConfig>) : ISheriffReasoningBoardConfig.Pack(builder, _o.SheriffReasoningBoard);
			Offset<ISheriffMainBoardConfig> sheriffMainBoardOffset = (_o.SheriffMainBoard == null) ? default(Offset<ISheriffMainBoardConfig>) : ISheriffMainBoardConfig.Pack(builder, _o.SheriffMainBoard);
			Offset<ISheriffClueDetailBoardConfig> sheriffClueDetailBoardOffset = (_o.SheriffClueDetailBoard == null) ? default(Offset<ISheriffClueDetailBoardConfig>) : ISheriffClueDetailBoardConfig.Pack(builder, _o.SheriffClueDetailBoard);
			Offset<ITrackReturnDungeon> trackReturnDungeonOffset = (_o.TrackReturnDungeon == null) ? default(Offset<ITrackReturnDungeon>) : ITrackReturnDungeon.Pack(builder, _o.TrackReturnDungeon);
			Offset<ITrackHandBookBoardConfig> trackHandBookBoardOffset = (_o.TrackHandBookBoard == null) ? default(Offset<ITrackHandBookBoardConfig>) : ITrackHandBookBoardConfig.Pack(builder, _o.TrackHandBookBoard);
			return ITrackCustomBoard.CreateITrackCustomBoard(builder, trackPhoneMessageBoardOffset, trackQuestBranchBoardOffset, sheriffAnomalyProgressBoardOffset, sheriffReasoningBoardOffset, sheriffMainBoardOffset, sheriffClueDetailBoardOffset, trackReturnDungeonOffset, trackHandBookBoardOffset);
		}

		// Token: 0x0400C84D RID: 51277
		private Table __p;
	}
}
