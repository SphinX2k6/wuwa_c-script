using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041ED RID: 16877
	public struct ITrackCustomBoard : IFlatbufferObject
	{
		// Token: 0x170077BC RID: 30652
		// (get) Token: 0x06018E3A RID: 101946 RVA: 0x00394B5A File Offset: 0x00392D5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E3B RID: 101947 RVA: 0x00394B67 File Offset: 0x00392D67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E3C RID: 101948 RVA: 0x00394B70 File Offset: 0x00392D70
		public static ITrackCustomBoard GetRootAsITrackCustomBoard(ByteBuffer _bb)
		{
			return ITrackCustomBoard.GetRootAsITrackCustomBoard(_bb, default(ITrackCustomBoard));
		}

		// Token: 0x06018E3D RID: 101949 RVA: 0x00394B8C File Offset: 0x00392D8C
		public static ITrackCustomBoard GetRootAsITrackCustomBoard(ByteBuffer _bb, ITrackCustomBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018E3E RID: 101950 RVA: 0x00394BA9 File Offset: 0x00392DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018E3F RID: 101951 RVA: 0x00394BB8 File Offset: 0x00392DB8
		public ITrackCustomBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077BD RID: 30653
		// (get) Token: 0x06018E40 RID: 101952 RVA: 0x00394BC8 File Offset: 0x00392DC8
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

		// Token: 0x170077BE RID: 30654
		// (get) Token: 0x06018E41 RID: 101953 RVA: 0x00394C28 File Offset: 0x00392E28
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

		// Token: 0x170077BF RID: 30655
		// (get) Token: 0x06018E42 RID: 101954 RVA: 0x00394C88 File Offset: 0x00392E88
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

		// Token: 0x170077C0 RID: 30656
		// (get) Token: 0x06018E43 RID: 101955 RVA: 0x00394CE8 File Offset: 0x00392EE8
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

		// Token: 0x170077C1 RID: 30657
		// (get) Token: 0x06018E44 RID: 101956 RVA: 0x00394D48 File Offset: 0x00392F48
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

		// Token: 0x170077C2 RID: 30658
		// (get) Token: 0x06018E45 RID: 101957 RVA: 0x00394DA8 File Offset: 0x00392FA8
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

		// Token: 0x170077C3 RID: 30659
		// (get) Token: 0x06018E46 RID: 101958 RVA: 0x00394E08 File Offset: 0x00393008
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

		// Token: 0x06018E47 RID: 101959 RVA: 0x00394E68 File Offset: 0x00393068
		public static Offset<ITrackCustomBoard> CreateITrackCustomBoard(FlatBufferBuilder builder, Offset<IPhoneMessageBoardConfig> TrackPhoneMessageBoardOffset = default(Offset<IPhoneMessageBoardConfig>), Offset<ITrackQuestBranchBoardConfig> TrackQuestBranchBoardOffset = default(Offset<ITrackQuestBranchBoardConfig>), Offset<ISheriffAnomalyProgressBoardConfig> SheriffAnomalyProgressBoardOffset = default(Offset<ISheriffAnomalyProgressBoardConfig>), Offset<ISheriffReasoningBoardConfig> SheriffReasoningBoardOffset = default(Offset<ISheriffReasoningBoardConfig>), Offset<ISheriffMainBoardConfig> SheriffMainBoardOffset = default(Offset<ISheriffMainBoardConfig>), Offset<ISheriffClueDetailBoardConfig> SheriffClueDetailBoardOffset = default(Offset<ISheriffClueDetailBoardConfig>), Offset<ITrackReturnDungeon> TrackReturnDungeonOffset = default(Offset<ITrackReturnDungeon>))
		{
			builder.StartTable(7);
			ITrackCustomBoard.AddTrackReturnDungeon(builder, TrackReturnDungeonOffset);
			ITrackCustomBoard.AddSheriffClueDetailBoard(builder, SheriffClueDetailBoardOffset);
			ITrackCustomBoard.AddSheriffMainBoard(builder, SheriffMainBoardOffset);
			ITrackCustomBoard.AddSheriffReasoningBoard(builder, SheriffReasoningBoardOffset);
			ITrackCustomBoard.AddSheriffAnomalyProgressBoard(builder, SheriffAnomalyProgressBoardOffset);
			ITrackCustomBoard.AddTrackQuestBranchBoard(builder, TrackQuestBranchBoardOffset);
			ITrackCustomBoard.AddTrackPhoneMessageBoard(builder, TrackPhoneMessageBoardOffset);
			return ITrackCustomBoard.EndITrackCustomBoard(builder);
		}

		// Token: 0x06018E48 RID: 101960 RVA: 0x00394EB7 File Offset: 0x003930B7
		public static void StartITrackCustomBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06018E49 RID: 101961 RVA: 0x00394EC0 File Offset: 0x003930C0
		public static void AddTrackPhoneMessageBoard(FlatBufferBuilder builder, Offset<IPhoneMessageBoardConfig> trackPhoneMessageBoardOffset)
		{
			builder.AddOffset(0, trackPhoneMessageBoardOffset.Value, 0);
		}

		// Token: 0x06018E4A RID: 101962 RVA: 0x00394ED0 File Offset: 0x003930D0
		public static void AddTrackQuestBranchBoard(FlatBufferBuilder builder, Offset<ITrackQuestBranchBoardConfig> trackQuestBranchBoardOffset)
		{
			builder.AddOffset(1, trackQuestBranchBoardOffset.Value, 0);
		}

		// Token: 0x06018E4B RID: 101963 RVA: 0x00394EE0 File Offset: 0x003930E0
		public static void AddSheriffAnomalyProgressBoard(FlatBufferBuilder builder, Offset<ISheriffAnomalyProgressBoardConfig> sheriffAnomalyProgressBoardOffset)
		{
			builder.AddOffset(2, sheriffAnomalyProgressBoardOffset.Value, 0);
		}

		// Token: 0x06018E4C RID: 101964 RVA: 0x00394EF0 File Offset: 0x003930F0
		public static void AddSheriffReasoningBoard(FlatBufferBuilder builder, Offset<ISheriffReasoningBoardConfig> sheriffReasoningBoardOffset)
		{
			builder.AddOffset(3, sheriffReasoningBoardOffset.Value, 0);
		}

		// Token: 0x06018E4D RID: 101965 RVA: 0x00394F00 File Offset: 0x00393100
		public static void AddSheriffMainBoard(FlatBufferBuilder builder, Offset<ISheriffMainBoardConfig> sheriffMainBoardOffset)
		{
			builder.AddOffset(4, sheriffMainBoardOffset.Value, 0);
		}

		// Token: 0x06018E4E RID: 101966 RVA: 0x00394F10 File Offset: 0x00393110
		public static void AddSheriffClueDetailBoard(FlatBufferBuilder builder, Offset<ISheriffClueDetailBoardConfig> sheriffClueDetailBoardOffset)
		{
			builder.AddOffset(5, sheriffClueDetailBoardOffset.Value, 0);
		}

		// Token: 0x06018E4F RID: 101967 RVA: 0x00394F20 File Offset: 0x00393120
		public static void AddTrackReturnDungeon(FlatBufferBuilder builder, Offset<ITrackReturnDungeon> trackReturnDungeonOffset)
		{
			builder.AddOffset(6, trackReturnDungeonOffset.Value, 0);
		}

		// Token: 0x06018E50 RID: 101968 RVA: 0x00394F30 File Offset: 0x00393130
		public static Offset<ITrackCustomBoard> EndITrackCustomBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITrackCustomBoard>(builder.EndTable());
		}

		// Token: 0x06018E51 RID: 101969 RVA: 0x00394F40 File Offset: 0x00393140
		public ITrackCustomBoardT UnPack()
		{
			ITrackCustomBoardT trackCustomBoardT = new ITrackCustomBoardT();
			this.UnPackTo(trackCustomBoardT);
			return trackCustomBoardT;
		}

		// Token: 0x06018E52 RID: 101970 RVA: 0x00394F5C File Offset: 0x0039315C
		public void UnPackTo(ITrackCustomBoardT _o)
		{
			_o.TrackPhoneMessageBoard = ((this.TrackPhoneMessageBoard != null) ? this.TrackPhoneMessageBoard.Value.UnPack() : null);
			_o.TrackQuestBranchBoard = ((this.TrackQuestBranchBoard != null) ? this.TrackQuestBranchBoard.Value.UnPack() : null);
			_o.SheriffAnomalyProgressBoard = ((this.SheriffAnomalyProgressBoard != null) ? this.SheriffAnomalyProgressBoard.Value.UnPack() : null);
			_o.SheriffReasoningBoard = ((this.SheriffReasoningBoard != null) ? this.SheriffReasoningBoard.Value.UnPack() : null);
			_o.SheriffMainBoard = ((this.SheriffMainBoard != null) ? this.SheriffMainBoard.Value.UnPack() : null);
			_o.SheriffClueDetailBoard = ((this.SheriffClueDetailBoard != null) ? this.SheriffClueDetailBoard.Value.UnPack() : null);
			_o.TrackReturnDungeon = ((this.TrackReturnDungeon != null) ? this.TrackReturnDungeon.Value.UnPack() : null);
		}

		// Token: 0x06018E53 RID: 101971 RVA: 0x003950C4 File Offset: 0x003932C4
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
			return ITrackCustomBoard.CreateITrackCustomBoard(builder, trackPhoneMessageBoardOffset, trackQuestBranchBoardOffset, sheriffAnomalyProgressBoardOffset, sheriffReasoningBoardOffset, sheriffMainBoardOffset, sheriffClueDetailBoardOffset, trackReturnDungeonOffset);
		}

		// Token: 0x0400BE43 RID: 48707
		private Table __p;
	}
}
