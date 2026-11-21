using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FEF RID: 20463
	public struct ICheckRhythmSpaceshipReachLevelRank : IFlatbufferObject
	{
		// Token: 0x17009264 RID: 37476
		// (get) Token: 0x0601FED3 RID: 130771 RVA: 0x0046ED1A File Offset: 0x0046CF1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FED4 RID: 130772 RVA: 0x0046ED27 File Offset: 0x0046CF27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FED5 RID: 130773 RVA: 0x0046ED30 File Offset: 0x0046CF30
		public static ICheckRhythmSpaceshipReachLevelRank GetRootAsICheckRhythmSpaceshipReachLevelRank(ByteBuffer _bb)
		{
			return ICheckRhythmSpaceshipReachLevelRank.GetRootAsICheckRhythmSpaceshipReachLevelRank(_bb, default(ICheckRhythmSpaceshipReachLevelRank));
		}

		// Token: 0x0601FED6 RID: 130774 RVA: 0x0046ED4C File Offset: 0x0046CF4C
		public static ICheckRhythmSpaceshipReachLevelRank GetRootAsICheckRhythmSpaceshipReachLevelRank(ByteBuffer _bb, ICheckRhythmSpaceshipReachLevelRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FED7 RID: 130775 RVA: 0x0046ED69 File Offset: 0x0046CF69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FED8 RID: 130776 RVA: 0x0046ED78 File Offset: 0x0046CF78
		public ICheckRhythmSpaceshipReachLevelRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009265 RID: 37477
		// (get) Token: 0x0601FED9 RID: 130777 RVA: 0x0046ED88 File Offset: 0x0046CF88
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009266 RID: 37478
		// (get) Token: 0x0601FEDA RID: 130778 RVA: 0x0046EDC4 File Offset: 0x0046CFC4
		public int RhythmSpaceshipLevelId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009267 RID: 37479
		// (get) Token: 0x0601FEDB RID: 130779 RVA: 0x0046EE00 File Offset: 0x0046D000
		public ERhythmSpaceshipLevelRank Rank
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERhythmSpaceshipLevelRank.None;
				}
				return (ERhythmSpaceshipLevelRank)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FEDC RID: 130780 RVA: 0x0046EE3C File Offset: 0x0046D03C
		public static Offset<ICheckRhythmSpaceshipReachLevelRank> CreateICheckRhythmSpaceshipReachLevelRank(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int RhythmSpaceshipLevelId = 0, ERhythmSpaceshipLevelRank Rank = ERhythmSpaceshipLevelRank.None)
		{
			builder.StartTable(3);
			ICheckRhythmSpaceshipReachLevelRank.AddRhythmSpaceshipLevelId(builder, RhythmSpaceshipLevelId);
			ICheckRhythmSpaceshipReachLevelRank.AddRank(builder, Rank);
			ICheckRhythmSpaceshipReachLevelRank.AddType(builder, Type);
			return ICheckRhythmSpaceshipReachLevelRank.EndICheckRhythmSpaceshipReachLevelRank(builder);
		}

		// Token: 0x0601FEDD RID: 130781 RVA: 0x0046EE60 File Offset: 0x0046D060
		public static void StartICheckRhythmSpaceshipReachLevelRank(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FEDE RID: 130782 RVA: 0x0046EE69 File Offset: 0x0046D069
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FEDF RID: 130783 RVA: 0x0046EE74 File Offset: 0x0046D074
		public static void AddRhythmSpaceshipLevelId(FlatBufferBuilder builder, int rhythmSpaceshipLevelId)
		{
			builder.AddInt(1, rhythmSpaceshipLevelId, 0);
		}

		// Token: 0x0601FEE0 RID: 130784 RVA: 0x0046EE7F File Offset: 0x0046D07F
		public static void AddRank(FlatBufferBuilder builder, ERhythmSpaceshipLevelRank rank)
		{
			builder.AddByte(2, (byte)rank, 0);
		}

		// Token: 0x0601FEE1 RID: 130785 RVA: 0x0046EE8A File Offset: 0x0046D08A
		public static Offset<ICheckRhythmSpaceshipReachLevelRank> EndICheckRhythmSpaceshipReachLevelRank(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRhythmSpaceshipReachLevelRank>(builder.EndTable());
		}

		// Token: 0x0601FEE2 RID: 130786 RVA: 0x0046EE98 File Offset: 0x0046D098
		public ICheckRhythmSpaceshipReachLevelRankT UnPack()
		{
			ICheckRhythmSpaceshipReachLevelRankT checkRhythmSpaceshipReachLevelRankT = new ICheckRhythmSpaceshipReachLevelRankT();
			this.UnPackTo(checkRhythmSpaceshipReachLevelRankT);
			return checkRhythmSpaceshipReachLevelRankT;
		}

		// Token: 0x0601FEE3 RID: 130787 RVA: 0x0046EEB3 File Offset: 0x0046D0B3
		public void UnPackTo(ICheckRhythmSpaceshipReachLevelRankT _o)
		{
			_o.Type = this.Type;
			_o.RhythmSpaceshipLevelId = this.RhythmSpaceshipLevelId;
			_o.Rank = this.Rank;
		}

		// Token: 0x0601FEE4 RID: 130788 RVA: 0x0046EEDC File Offset: 0x0046D0DC
		public static Offset<ICheckRhythmSpaceshipReachLevelRank> Pack(FlatBufferBuilder builder, ICheckRhythmSpaceshipReachLevelRankT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRhythmSpaceshipReachLevelRank>);
			}
			return ICheckRhythmSpaceshipReachLevelRank.CreateICheckRhythmSpaceshipReachLevelRank(builder, _o.Type, _o.RhythmSpaceshipLevelId, _o.Rank);
		}

		// Token: 0x0400DEA1 RID: 56993
		private Table __p;
	}
}
